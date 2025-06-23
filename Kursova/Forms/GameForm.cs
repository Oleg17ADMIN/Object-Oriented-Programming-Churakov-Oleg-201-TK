using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Logic;

namespace Kursova.Forms
{
    public partial class GameForm : Form
    {
        // Константи розмірів клітинки та розміру поля
        private const int CellSize = 40;
        private const int GridSize = 15;

        // Масив кнопок для ігрового поля
        private Button[,] buttons = new Button[GridSize, GridSize];

        // Ігрова логіка
        private Board board;

        // Гравці
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        // Режим гри: гра проти комп'ютера чи людини
        private bool vsComputer = false;

        // Вибрана складність для AI
        private AIDifficulty selectedDifficulty = AIDifficulty.Medium;

        // Рахунок
        private int humanWins = 0;
        private int computerWins = 0;
        private int draws = 0;

        // Елементи UI
        private Panel scrollContainer;
        private Panel panelBoard;
        private Label labelStatus;
        private Label labelScore;
        private Button btnEasy;
        private Button btnMedium;
        private Button btnHard;
        private Button btnNewGame;
        private Button btnVsHuman;
        private Button btnVsAI;
        private Button btnSave;
        private Label difficultyLabel;

        public GameForm()
        {
            InitializeComponent();
            InitializeGameUI();
        }

        /// <summary>
        /// Ініціалізація користувацького інтерфейсу гри.
        /// </summary>
        private void InitializeGameUI()
        {
            // Заголовок та розмір вікна
            this.Text = "Гра Хрестики-нулики (Kursova)";
            this.Size = new Size(900, 750);
            this.BackColor = Color.WhiteSmoke;

            // Контейнер з прокруткою для дошки гри
            scrollContainer = new Panel
            {
                Location = new Point(20, 100),
                Size = new Size(CellSize * GridSize + 20, CellSize * GridSize + 20),
                AutoScroll = true
            };
            this.Controls.Add(scrollContainer);

            // Панель для кнопок ігрового поля
            panelBoard = new Panel
            {
                Size = new Size(CellSize * GridSize, CellSize * GridSize),
                BackColor = Color.LightGray,
                Name = "panelBoard",
                Location = new Point(0, 0)
            };
            scrollContainer.Controls.Add(panelBoard);

            // Статусна мітка (поточний хід)
            labelStatus = new Label
            {
                Text = "Оберіть режим гри",
                Location = new Point(20, 20),
                Width = 600,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            this.Controls.Add(labelStatus);

            // Мітка з рахунком
            labelScore = new Label
            {
                Text = "🏆 Людина: 0 | Комп’ютер: 0 | Нічиї: 0",
                Location = new Point(20, 50),
                Width = 600,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            this.Controls.Add(labelScore);

            // Кнопки вибору складності
            btnEasy = CreateModeButton("Легкий", Color.LightGreen, new Point(650, 200), () => {
                selectedDifficulty = AIDifficulty.Easy;
                UpdateDifficultyLabel();
            });
            btnMedium = CreateModeButton("Середній", Color.Gold, new Point(650, 240), () => {
                selectedDifficulty = AIDifficulty.Medium;
                UpdateDifficultyLabel();
            });
            btnHard = CreateModeButton("Складний", Color.Tomato, new Point(650, 280), () => {
                selectedDifficulty = AIDifficulty.Hard;
                UpdateDifficultyLabel();
            });
            this.Controls.AddRange(new Control[] { btnEasy, btnMedium, btnHard });

            // Індикатор складності
            difficultyLabel = new Label
            {
                Location = new Point(650, 320),
                Size = new Size(200, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            UpdateDifficultyLabel();
            this.Controls.Add(difficultyLabel);

            // Кнопка "Нова гра"
            btnNewGame = new Button
            {
                Text = "Нова гра",
                Location = new Point(650, 20),
                Size = new Size(200, 30)
            };
            btnNewGame.Click += (s, e) => StartNewGame();
            this.Controls.Add(btnNewGame);

            // Кнопка "Людина проти Людини"
            btnVsHuman = new Button
            {
                Text = "Людина проти Людини",
                Location = new Point(650, 60),
                Size = new Size(200, 30)
            };
            btnVsHuman.Click += (s, e) =>
            {
                vsComputer = false;
                StartNewGame();
            };
            this.Controls.Add(btnVsHuman);

            // Кнопка "Людина проти Комп'ютера"
            btnVsAI = new Button
            {
                Text = "Людина проти Комп'ютера",
                Location = new Point(650, 100),
                Size = new Size(200, 30)
            };
            btnVsAI.Click += (s, e) =>
            {
                vsComputer = true;
                StartNewGame();
            };
            this.Controls.Add(btnVsAI);

            // Кнопка збереження статистики
            btnSave = new Button
            {
                Text = "Зберегти статистику",
                Location = new Point(650, 140),
                Size = new Size(200, 30)
            };
            btnSave.Click += (s, e) => SaveStatsToFile();
            this.Controls.Add(btnSave);

            // Створення кнопок ігрового поля
            for (int y = 0; y < GridSize; y++)
            {
                for (int x = 0; x < GridSize; x++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(x * CellSize, y * CellSize),
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        Tag = new Point(x, y),
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Standard
                    };
                    btn.Click += Cell_Click;
                    panelBoard.Controls.Add(btn);
                    buttons[x, y] = btn;
                }
            }
        }

        /// <summary>
        /// Оновлення індикатора складності
        /// </summary>
        private void UpdateDifficultyLabel()
        {
            difficultyLabel.Text = $"Рівень: {selectedDifficulty.ToString()}";
            difficultyLabel.ForeColor = selectedDifficulty switch
            {
                AIDifficulty.Easy => Color.Green,
                AIDifficulty.Medium => Color.Blue,
                AIDifficulty.Hard => Color.Red,
                _ => Color.Black
            };
        }

        /// <summary>
        /// Створення кнопки вибору складності.
        /// </summary>
        private Button CreateModeButton(string text, Color color, Point location, Action onClick)
        {
            Button btn = new Button
            {
                Text = text,
                BackColor = color,
                Location = location,
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btn.Click += (s, e) => onClick();
            return btn;
        }

        /// <summary>
        /// Обробник кліку по клітинці.
        /// </summary>
        private void Cell_Click(object sender, EventArgs e)
        {
            // Якщо зараз не хід людини - ігнорувати
            if (!(currentPlayer is HumanPlayer)) return;

            Button btn = (Button)sender;
            Point point = (Point)btn.Tag;
            int x = point.X;
            int y = point.Y;

            // Якщо клітинка зайнята - ігнорувати
            if (!board.IsEmpty(x, y)) return;

            // Зробити хід
            MakeMove(x, y);
        }

        /// <summary>
        /// Виконання ходу гравця.
        /// </summary>
        private void MakeMove(int x, int y)
        {
            // Перевірка меж
            if (x < 0 || x >= GridSize || y < 0 || y >= GridSize)
            {
                MessageBox.Show("Хід вийшов за межі поля візуалізації.");
                return;
            }

            // Розміщення символу на дошці та оновлення кнопки
            board.PlaceSymbol(x, y, currentPlayer.Symbol);
            buttons[x, y].Text = currentPlayer.Symbol.ToString();
            buttons[x, y].Enabled = false;
            buttons[x, y].BackColor = currentPlayer.Symbol == 'X' ? Color.LightCoral : Color.LightBlue;

            // Перевірка перемоги
            if (board.CheckWin(x, y, currentPlayer.Symbol))
            {
                HighlightWinningLine(x, y, currentPlayer.Symbol);

                // Оновлення рахунку
                if ((currentPlayer == player1 && player1 is HumanPlayer) ||
                    (currentPlayer == player2 && player2 is HumanPlayer))
                {
                    humanWins++;
                }
                else
                {
                    computerWins++;
                }

                UpdateScore();
                EndGame($"🎉 Гравець {currentPlayer.Symbol} переміг!");
                return;
            }

            // Перевірка нічиєї
            if (IsDraw())
            {
                draws++;
                UpdateScore();
                EndGame("🤝 Нічия!");
                return;
            }

            // Перемикання гравця
            currentPlayer = currentPlayer == player1 ? player2 : player1;
            labelStatus.Text = $"Хід: {currentPlayer.Symbol}";

            // Якщо зараз хід комп'ютера — зробити хід
            if (currentPlayer is ComputerPlayer)
            {
                ComputerMoveAsync();
            }
        }

        /// <summary>
        /// Асинхронний хід комп'ютера
        /// </summary>
        private async void ComputerMoveAsync()
        {
            // Блокуємо UI під час "думання" комп'ютера
            SetControlsEnabled(false);
            labelStatus.Text = $"{currentPlayer.Symbol} думає...";

            await Task.Run(() =>
            {
                // Штучна затримка для реалізму
                Thread.Sleep(500);

                // Виконуємо хід комп'ютера в UI потокі
                this.Invoke(new Action(() =>
                {
                    if (currentPlayer is ComputerPlayer comp)
                    {
                        var move = comp.MakeMove(board);
                        if (move != (-1, -1))
                        {
                            MakeMove(move.Item1, move.Item2);
                        }
                    }
                    SetControlsEnabled(true);
                }));
            });
        }

        /// <summary>
        /// Увімкнення/вимкнення елементів керування під час ходу комп'ютера
        /// </summary>
        private void SetControlsEnabled(bool enabled)
        {
            btnNewGame.Enabled = enabled;
            btnVsHuman.Enabled = enabled;
            btnVsAI.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnEasy.Enabled = enabled;
            btnMedium.Enabled = enabled;
            btnHard.Enabled = enabled;

            foreach (Button btn in buttons)
            {
                btn.Enabled = enabled;
            }
        }

        /// <summary>
        /// Підсвічування виграшної лінії.
        /// </summary>
        private void HighlightWinningLine(int x, int y, char symbol)
        {
            (int dx, int dy)[] directions = {
                (1, 0),    // горизонталь
                (0, 1),    // вертикаль
                (1, 1),    // діагональ \
                (1, -1)    // діагональ /
            };

            foreach (var (dx, dy) in directions)
            {
                int consecutive = 1;
                var winningButtons = new List<Button> { buttons[x, y] };

                // Перевірка вперед по напрямку
                for (int i = 1; i <= 4; i++)
                {
                    int nx = x + dx * i;
                    int ny = y + dy * i;

                    if (nx < 0 || nx >= GridSize || ny < 0 || ny >= GridSize)
                        break;

                    if (board.GetCell(nx, ny) == symbol)
                    {
                        consecutive++;
                        winningButtons.Add(buttons[nx, ny]);
                    }
                    else
                    {
                        break;
                    }
                }

                // Перевірка назад по напрямку
                for (int i = 1; i <= 4; i++)
                {
                    int nx = x - dx * i;
                    int ny = y - dy * i;

                    if (nx < 0 || nx >= GridSize || ny < 0 || ny >= GridSize)
                        break;

                    if (board.GetCell(nx, ny) == symbol)
                    {
                        consecutive++;
                        winningButtons.Add(buttons[nx, ny]);
                    }
                    else
                    {
                        break;
                    }
                }

                // Якщо знайдено 5 і більше у ряд — підсвітити
                if (consecutive >= 5)
                {
                    foreach (var btn in winningButtons)
                        btn.BackColor = Color.LightGreen;
                    return;
                }
            }
        }

        /// <summary>
        /// Оновлення відображення рахунку.
        /// </summary>
        private void UpdateScore()
        {
            labelScore.Text = $"🏆 Людина: {humanWins} | Комп’ютер: {computerWins} | Нічиї: {draws}";
        }

        /// <summary>
        /// Збереження статистики у файл.
        /// </summary>
        private void SaveStatsToFile()
        {
            string path = "tic_tac_toe_stats.txt";
            string text = $"Дата: {DateTime.Now}\nЛюдина: {humanWins}\nКомп’ютер: {computerWins}\nНічиї: {draws}\nРежим: {selectedDifficulty}\n---\n";

            try
            {
                File.AppendAllText(path, text);
                MessageBox.Show("Статистику збережено до файлу: " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні статистики: " + ex.Message);
            }
        }

        /// <summary>
        /// Перевірка нічиєї.
        /// </summary>
        private bool IsDraw()
        {
            // Нічия, якщо немає доступних ходів
            return board.GetAvailableMoves().Count == 0;
        }

        /// <summary>
        /// Завершення гри - відключення поля та вивід повідомлення.
        /// </summary>
        private void EndGame(string message)
        {
            SetControlsEnabled(false);
            labelStatus.Text = message;
        }

        /// <summary>
        /// Початок нової гри - скидання стану.
        /// </summary>
        private void StartNewGame()
        {
            board = new Board();

            // Очищення кнопок поля
            for (int y = 0; y < GridSize; y++)
            {
                for (int x = 0; x < GridSize; x++)
                {
                    buttons[x, y].Text = "";
                    buttons[x, y].Enabled = true;
                    buttons[x, y].BackColor = Color.White;
                }
            }

            // Визначення гравців залежно від режиму
            if (vsComputer)
            {
                player1 = new ComputerPlayer('X', selectedDifficulty);
                player2 = new HumanPlayer('O');
            }
            else
            {
                player1 = new HumanPlayer('X');
                player2 = new HumanPlayer('O');
            }

            currentPlayer = player1;
            labelStatus.Text = $"Хід: {currentPlayer.Symbol}";
            SetControlsEnabled(true);

            // Якщо хід комп'ютера початковий — робимо хід
            if (currentPlayer is ComputerPlayer)
            {
                ComputerMoveAsync();
            }
        }
    }
}