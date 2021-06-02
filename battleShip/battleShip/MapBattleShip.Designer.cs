namespace battleShip
{
    partial class MapBattleShip
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapBattleShip));
            this.playerScore = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(400, 98);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(46, 31);
            this.playerScore.TabIndex = 2;
            this.playerScore.Text = "00";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.BackColor = System.Drawing.Color.Transparent;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyScore.ForeColor = System.Drawing.Color.White;
            this.enemyScore.Location = new System.Drawing.Point(897, 101);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(46, 31);
            this.enemyScore.TabIndex = 3;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyMoves.ForeColor = System.Drawing.Color.White;
            this.enemyMoves.Location = new System.Drawing.Point(900, 35);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(26, 26);
            this.enemyMoves.TabIndex = 4;
            this.enemyMoves.Text = "  ";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundsText.ForeColor = System.Drawing.Color.White;
            this.roundsText.Location = new System.Drawing.Point(498, 173);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(72, 20);
            this.roundsText.TabIndex = 5;
            this.roundsText.Text = "Раунды";
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpText.ForeColor = System.Drawing.Color.LightGreen;
            this.helpText.Location = new System.Drawing.Point(122, 538);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(323, 15);
            this.helpText.TabIndex = 6;
            this.helpText.Text = "1) Нажми на 3 различные кнопки на карте для старта ";
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.BackColor = System.Drawing.Color.SeaGreen;
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.DropDownWidth = 95;
            this.enemyLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyLocationList.ForeColor = System.Drawing.Color.White;
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(171, 29);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(118, 28);
            this.enemyLocationList.TabIndex = 7;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackButton.Location = new System.Drawing.Point(295, 23);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(80, 40);
            this.attackButton.TabIndex = 8;
            this.attackButton.Text = "Атака";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.AttackEnemyPosition);
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(110, 231);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(75, 55);
            this.w1.TabIndex = 9;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(199, 231);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(75, 55);
            this.w2.TabIndex = 10;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(295, 231);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(75, 55);
            this.w3.TabIndex = 11;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(383, 231);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(75, 55);
            this.w4.TabIndex = 12;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(110, 307);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 55);
            this.x1.TabIndex = 13;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(199, 307);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 55);
            this.x2.TabIndex = 14;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(293, 307);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(75, 55);
            this.x3.TabIndex = 15;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(382, 307);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(75, 55);
            this.x4.TabIndex = 16;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(110, 389);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(75, 55);
            this.y1.TabIndex = 17;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(199, 389);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(75, 55);
            this.y2.TabIndex = 18;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(295, 389);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(75, 55);
            this.y3.TabIndex = 19;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(383, 389);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(75, 55);
            this.y4.TabIndex = 20;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(110, 459);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(75, 55);
            this.z1.TabIndex = 21;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(199, 459);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(75, 55);
            this.z2.TabIndex = 22;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(293, 459);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(75, 55);
            this.z3.TabIndex = 23;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(382, 459);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(75, 55);
            this.z4.TabIndex = 24;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.PickingPlayerPosition);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(605, 231);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 55);
            this.a1.TabIndex = 25;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(698, 231);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 55);
            this.a2.TabIndex = 26;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(792, 231);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 55);
            this.a3.TabIndex = 27;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(882, 231);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 55);
            this.a4.TabIndex = 28;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(605, 307);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 55);
            this.b1.TabIndex = 29;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(698, 307);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 55);
            this.b2.TabIndex = 30;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(792, 307);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 55);
            this.b3.TabIndex = 31;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(882, 307);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 55);
            this.b4.TabIndex = 32;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(605, 389);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 55);
            this.c1.TabIndex = 33;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(698, 389);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 55);
            this.c2.TabIndex = 34;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(792, 389);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 55);
            this.c3.TabIndex = 35;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(882, 389);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(75, 55);
            this.c4.TabIndex = 36;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(605, 459);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 37;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(698, 459);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 38;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(792, 459);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 55);
            this.d3.TabIndex = 39;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(882, 459);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 55);
            this.d4.TabIndex = 40;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.AttackEnemyPlayer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 585);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.Name = "Form1";
            this.Text = "BattleShip Game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Timer enemyPlayTimer;
    }
}

