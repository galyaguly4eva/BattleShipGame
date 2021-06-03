using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //позволяет создать журнал отладки в окне выход

namespace battleShip
{
    public partial class MapBattleShip : Form
    {
        List<Button> playerPosition; // листы для того чтобы эффективно и организовать список
        List<Button> enemyPosition;

        
        Random rand = new Random(); // мы будем использовать его, чтобы позволить ИИ случайным образом выбрать 3 позиции 

        int totalShips = 3; // количество кораблей игрока
        int rounds = 16; 
        int playerTotalScore ; 
        int enemyTotalScore; 
        public MapBattleShip()
        {
            InitializeComponent();
            RestartGame(); 
        }

        private void AttackEnemyPlayer(object sender, EventArgs e)
        {
            if (playerPosition.Count > 0 && rounds > 0)
            {

                rounds--; // уменьшаем колиество раундов
                roundsText.Text = "Раунды " + rounds; // показывает количество оставшихся раундов

                int index = rand.Next(playerPosition.Count); // создает новый индекс и помещает кнопку ИИ

                if ((string)playerPosition[index].Tag == "корабль игрока")
                {
                    //если попало в корабль
                    playerPosition[index].BackgroundImage = Resource1.fire;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = Color.DarkBlue;
                    playerPosition.RemoveAt(index);
                    // удаляет кнопку из списка, чтобы процессор больше ее не атаковал 
                    enemyTotalScore++;
                    enemyScore.Text = ""+ enemyTotalScore;
                    enemyPlayTimer.Stop();
                    //останавливает время для процессора
                }
                else
                {
                    // если не попало в корабль
                    playerPosition[index].BackgroundImage = Resource1.miss;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = Color.DarkBlue;
                    playerPosition.RemoveAt(index);
                    // удаляет кнопку из списка, чтобы процессор больше ее не атаковал 
                    enemyPlayTimer.Stop();
                    // останавливает таймер для процессора
                }

            }

            // показывает исход игры
            if (rounds < 1 || enemyTotalScore > 2 || playerTotalScore > 2 )
            {
                if (playerTotalScore > enemyTotalScore)
                {
                    MessageBox.Show("Ты выиграл", "Победа");
                    RestartGame();
                }
                else if (enemyTotalScore > playerTotalScore)
                {
                    MessageBox.Show("ХА-ха! Я потопил твой корабль", "Проигрыш");
                    RestartGame();
                }
                else if (playerTotalScore == enemyTotalScore)
                {
                    MessageBox.Show("Никто не выиграл", "Ничья");
                    RestartGame();
                }
            }
        }

        private void AttackEnemyPosition(object sender, EventArgs e)
        {
            if (enemyLocationList.Text != "")
            {
                var attackPos = enemyLocationList.Text;
                // дает ей значение текста, выбранного из списка.
                attackPos = attackPos.ToLower();
                int index = enemyPosition.FindIndex(a => a.Name == attackPos);
                // в этом int запускает индекс местоположения противника и будет искать строку, выбранную игроком
                // как только он будет найден, он будет сохранен внутри локальной переменной индекса

                // проверяет есть ли еще у игра раунды
                if (enemyPosition[index].Enabled && rounds > 0)
                {

                    rounds--;
                    roundsText.Text = "Раунды " + rounds;

                    if ((string)enemyPosition[index].Tag == "вражеский корабль")
                    {
                        // если игрок попадает в вражеский корабль
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Resource1.fire;
                        enemyPosition[index].BackColor = Color.DarkBlue;
                        playerTotalScore++;
                        playerScore.Text = "" + playerTotalScore;
                        enemyPlayTimer.Start();
                        // начинается таймер для процессора
                    }
                    else
                    {
                        // если игрок промахивается
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Resource1.miss;
                        enemyPosition[index].BackColor = Color.DarkBlue;
                        enemyPlayTimer.Start();
                        // начинается таймер для процессора
                    }
                }
            }

            else
            {
                // если игрок не выбирает местоположение из выпадающего списка, предупредите его об этом
                MessageBox.Show("Выберите клетку из списка. ");
            }

        }

        private void PickingPlayerPosition(object sender, EventArgs e)
        {
            //метод который работает каждый раз, когда игрок начинает выбирать свои корабли
            if (totalShips > 0)
            {
                var button = (Button)sender;
                button.Enabled = false;
                button.Tag = "корабль игрока";
                button.BackColor = Color.Blue;
                totalShips--;
            }
            if (totalShips == 0)
            {
                attackButton.Enabled = true;
                attackButton.BackColor = Color.Red;
                helpText.Top = 70;
                helpText.Left = 170;
                helpText.Text = "2) Теперь выберите позицию атаки из списка";
            }

        }

        private void RestartGame()
        {
            // эта функция загрузит все кнопки в списки, которые мы объявили выше
            playerPosition = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPosition = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            enemyLocationList.Items.Clear();
            enemyLocationList.Text = null;

            //эти циклы будут проходить через каждую кнопку вражеской и пользовательской позиций
            // затем он добавит их в список местоположения противника для нас
            // он также удалит все теги с кнопок расположения противника и игрока
            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Enabled = true;
                enemyPosition[i].Tag = null;
                enemyPosition[i].BackColor = Color.White;
                enemyPosition[i].BackgroundImage = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);

            }
            for (int i = 0; i < playerPosition.Count; i++)
            {
                playerPosition[i].Enabled = true;
                playerPosition[i].Tag = null;
                playerPosition[i].BackColor = Color.White;
                playerPosition[i].BackgroundImage = null;
            }
            //обнулит все значения
            playerTotalScore = 0;
            enemyTotalScore = 0;
            rounds = 16;
            totalShips = 3;

            playerScore.Text = playerTotalScore.ToString();
            enemyScore.Text = enemyTotalScore.ToString();
            enemyMoves.Text = "  ";

            attackButton.Enabled = false;
            PickingEnemyPositions();

        }
        public static IEnumerable<int> GetRandomNumbers(Random rand, List<Button> enemyPosition)
        {
            HashSet<int> randomNumbers = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPosition.Count);
                while (!randomNumbers.Add(rand.Next())) ;
            }
            return randomNumbers;
        }

        private void PickingEnemyPositions()
        {
            var pickedNumbers = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPosition.Count);
                while (pickedNumbers.Contains(index))
                    index = rand.Next(enemyPosition.Count);
                // выбирается рандомно кнопка из списка без повтора

                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    // если кнопка доступна для выбора
                    enemyPosition[index].Tag = "вражеский корабль";
                    // добавляет вражеский корабль

                    Debug.WriteLine("Позиция противника " + enemyPosition[index].Text);
                    // строка выше покажет нам в окне отладки, какие кнопки выбрал враг
                    // это может помочь нам выяснить, работает ли игра так, как задумано
                }
                else
                {
                    // если верхнее условие не выполнилось, то мы снова его запускаем пока не будет 3 корабля
                    index = rand.Next(enemyPosition.Count);
                }
                pickedNumbers.Add(index);
            }
        }
    }
}
