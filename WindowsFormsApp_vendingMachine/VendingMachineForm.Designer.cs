namespace WindowsFormsApp_vendingMachine
{
    partial class VendingMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.button_callManager = new System.Windows.Forms.Button();
            this.label_drinkPrice = new System.Windows.Forms.Label();
            this.button_drink = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label_manager = new System.Windows.Forms.Label();
            this.label_userMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_drinkSupply = new System.Windows.Forms.Button();
            this.button_profitGain = new System.Windows.Forms.Button();
            this.button_changeSupply = new System.Windows.Forms.Button();
            this.textBox_drinkPriceChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_drinkPriceChange = new System.Windows.Forms.Button();
            this.label_machineStatus = new System.Windows.Forms.Label();
            this.textBox_insertedMoney = new System.Windows.Forms.TextBox();
            this.button_insertMoney = new System.Windows.Forms.Button();
            this.button_returnChange = new System.Windows.Forms.Button();
            this.textBox_userHaveMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_boughtDrink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_mgHaveMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_mcHaveMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_mcDrinkCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_returnDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(525, 645);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "관리자 호출";
            // 
            // button_callManager
            // 
            this.button_callManager.BackColor = System.Drawing.Color.Firebrick;
            this.button_callManager.FlatAppearance.BorderSize = 10;
            this.button_callManager.Location = new System.Drawing.Point(119, 387);
            this.button_callManager.Name = "button_callManager";
            this.button_callManager.Size = new System.Drawing.Size(32, 30);
            this.button_callManager.TabIndex = 13;
            this.button_callManager.UseVisualStyleBackColor = false;
            this.button_callManager.Click += new System.EventHandler(this.button_callManager_Click);
            // 
            // label_drinkPrice
            // 
            this.label_drinkPrice.AutoSize = true;
            this.label_drinkPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_drinkPrice.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_drinkPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_drinkPrice.Location = new System.Drawing.Point(210, 318);
            this.label_drinkPrice.Name = "label_drinkPrice";
            this.label_drinkPrice.Size = new System.Drawing.Size(78, 31);
            this.label_drinkPrice.TabIndex = 9;
            this.label_drinkPrice.Text = "label1";
            this.label_drinkPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_drink
            // 
            this.button_drink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_drink.FlatAppearance.BorderSize = 100;
            this.button_drink.Location = new System.Drawing.Point(126, 58);
            this.button_drink.Name = "button_drink";
            this.button_drink.Size = new System.Drawing.Size(250, 250);
            this.button_drink.TabIndex = 8;
            this.button_drink.UseVisualStyleBackColor = true;
            this.button_drink.Click += new System.EventHandler(this.button_drink_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_user.Location = new System.Drawing.Point(546, 25);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(55, 15);
            this.label_user.TabIndex = 15;
            this.label_user.Text = "사용자";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_manager
            // 
            this.label_manager.AutoSize = true;
            this.label_manager.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_manager.Location = new System.Drawing.Point(546, 185);
            this.label_manager.Name = "label_manager";
            this.label_manager.Size = new System.Drawing.Size(55, 15);
            this.label_manager.TabIndex = 16;
            this.label_manager.Text = "관리자";
            this.label_manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_userMoney
            // 
            this.label_userMoney.AutoSize = true;
            this.label_userMoney.Location = new System.Drawing.Point(578, 58);
            this.label_userMoney.Name = "label_userMoney";
            this.label_userMoney.Size = new System.Drawing.Size(87, 15);
            this.label_userMoney.TabIndex = 17;
            this.label_userMoney.Text = "보유 금액 : ";
            this.label_userMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "보유 금액 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_drinkSupply
            // 
            this.button_drinkSupply.Location = new System.Drawing.Point(549, 349);
            this.button_drinkSupply.Name = "button_drinkSupply";
            this.button_drinkSupply.Size = new System.Drawing.Size(95, 23);
            this.button_drinkSupply.TabIndex = 19;
            this.button_drinkSupply.Text = "음료 보충";
            this.button_drinkSupply.UseVisualStyleBackColor = true;
            this.button_drinkSupply.Click += new System.EventHandler(this.button_drinkSupply_Click);
            // 
            // button_profitGain
            // 
            this.button_profitGain.Location = new System.Drawing.Point(662, 445);
            this.button_profitGain.Name = "button_profitGain";
            this.button_profitGain.Size = new System.Drawing.Size(95, 23);
            this.button_profitGain.TabIndex = 20;
            this.button_profitGain.Text = "수익 회수";
            this.button_profitGain.UseVisualStyleBackColor = true;
            this.button_profitGain.Click += new System.EventHandler(this.button_profitGain_Click);
            // 
            // button_changeSupply
            // 
            this.button_changeSupply.Location = new System.Drawing.Point(550, 445);
            this.button_changeSupply.Name = "button_changeSupply";
            this.button_changeSupply.Size = new System.Drawing.Size(95, 23);
            this.button_changeSupply.TabIndex = 21;
            this.button_changeSupply.Text = "잔돈 보충";
            this.button_changeSupply.UseVisualStyleBackColor = true;
            this.button_changeSupply.Click += new System.EventHandler(this.button_changeSupply_Click);
            // 
            // textBox_drinkPriceChange
            // 
            this.textBox_drinkPriceChange.Location = new System.Drawing.Point(581, 292);
            this.textBox_drinkPriceChange.Name = "textBox_drinkPriceChange";
            this.textBox_drinkPriceChange.Size = new System.Drawing.Size(100, 25);
            this.textBox_drinkPriceChange.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "음료가격 변경";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_drinkPriceChange
            // 
            this.button_drinkPriceChange.Enabled = false;
            this.button_drinkPriceChange.Location = new System.Drawing.Point(711, 294);
            this.button_drinkPriceChange.Name = "button_drinkPriceChange";
            this.button_drinkPriceChange.Size = new System.Drawing.Size(62, 23);
            this.button_drinkPriceChange.TabIndex = 24;
            this.button_drinkPriceChange.Text = "변경";
            this.button_drinkPriceChange.UseVisualStyleBackColor = true;
            this.button_drinkPriceChange.Click += new System.EventHandler(this.button_drinkPriceChange_Click);
            // 
            // label_machineStatus
            // 
            this.label_machineStatus.AutoSize = true;
            this.label_machineStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_machineStatus.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_machineStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_machineStatus.Location = new System.Drawing.Point(122, 26);
            this.label_machineStatus.Name = "label_machineStatus";
            this.label_machineStatus.Size = new System.Drawing.Size(59, 23);
            this.label_machineStatus.TabIndex = 25;
            this.label_machineStatus.Text = "label1";
            this.label_machineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_insertedMoney
            // 
            this.textBox_insertedMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_insertedMoney.Location = new System.Drawing.Point(390, 361);
            this.textBox_insertedMoney.Name = "textBox_insertedMoney";
            this.textBox_insertedMoney.ReadOnly = true;
            this.textBox_insertedMoney.Size = new System.Drawing.Size(100, 25);
            this.textBox_insertedMoney.TabIndex = 26;
            this.textBox_insertedMoney.Text = "0";
            // 
            // button_insertMoney
            // 
            this.button_insertMoney.Location = new System.Drawing.Point(390, 411);
            this.button_insertMoney.Name = "button_insertMoney";
            this.button_insertMoney.Size = new System.Drawing.Size(92, 29);
            this.button_insertMoney.TabIndex = 27;
            this.button_insertMoney.Text = "돈 넣기";
            this.button_insertMoney.UseVisualStyleBackColor = true;
            this.button_insertMoney.Click += new System.EventHandler(this.button_insertMoney_Click);
            // 
            // button_returnChange
            // 
            this.button_returnChange.Location = new System.Drawing.Point(390, 452);
            this.button_returnChange.Name = "button_returnChange";
            this.button_returnChange.Size = new System.Drawing.Size(92, 29);
            this.button_returnChange.TabIndex = 28;
            this.button_returnChange.Text = "잔돈 받기";
            this.button_returnChange.UseVisualStyleBackColor = true;
            this.button_returnChange.Click += new System.EventHandler(this.button_returnChange_Click);
            // 
            // textBox_userHaveMoney
            // 
            this.textBox_userHaveMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_userHaveMoney.Location = new System.Drawing.Point(661, 55);
            this.textBox_userHaveMoney.Name = "textBox_userHaveMoney";
            this.textBox_userHaveMoney.ReadOnly = true;
            this.textBox_userHaveMoney.Size = new System.Drawing.Size(100, 25);
            this.textBox_userHaveMoney.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "구매한 음료 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_boughtDrink
            // 
            this.textBox_boughtDrink.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_boughtDrink.Location = new System.Drawing.Point(686, 95);
            this.textBox_boughtDrink.Name = "textBox_boughtDrink";
            this.textBox_boughtDrink.ReadOnly = true;
            this.textBox_boughtDrink.Size = new System.Drawing.Size(58, 25);
            this.textBox_boughtDrink.TabIndex = 31;
            this.textBox_boughtDrink.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "개";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "원";
            // 
            // textBox_mgHaveMoney
            // 
            this.textBox_mgHaveMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_mgHaveMoney.Location = new System.Drawing.Point(661, 219);
            this.textBox_mgHaveMoney.Name = "textBox_mgHaveMoney";
            this.textBox_mgHaveMoney.ReadOnly = true;
            this.textBox_mgHaveMoney.Size = new System.Drawing.Size(100, 25);
            this.textBox_mgHaveMoney.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(789, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "원";
            // 
            // textBox_mcHaveMoney
            // 
            this.textBox_mcHaveMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_mcHaveMoney.Location = new System.Drawing.Point(686, 483);
            this.textBox_mcHaveMoney.Name = "textBox_mcHaveMoney";
            this.textBox_mcHaveMoney.ReadOnly = true;
            this.textBox_mcHaveMoney.Size = new System.Drawing.Size(100, 25);
            this.textBox_mcHaveMoney.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "자판기 보유 금액 :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(747, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "개";
            // 
            // textBox_mcDrinkCount
            // 
            this.textBox_mcDrinkCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_mcDrinkCount.Location = new System.Drawing.Point(686, 388);
            this.textBox_mcDrinkCount.Name = "textBox_mcDrinkCount";
            this.textBox_mcDrinkCount.ReadOnly = true;
            this.textBox_mcDrinkCount.Size = new System.Drawing.Size(58, 25);
            this.textBox_mcDrinkCount.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "자판기 음료 개수 :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "원";
            // 
            // button_returnDrink
            // 
            this.button_returnDrink.Location = new System.Drawing.Point(126, 520);
            this.button_returnDrink.Name = "button_returnDrink";
            this.button_returnDrink.Size = new System.Drawing.Size(250, 82);
            this.button_returnDrink.TabIndex = 43;
            this.button_returnDrink.Text = "음료 꺼내기";
            this.button_returnDrink.UseVisualStyleBackColor = true;
            this.button_returnDrink.Click += new System.EventHandler(this.button_returnDrink_Click);
            // 
            // VendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 645);
            this.Controls.Add(this.button_returnDrink);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_mcDrinkCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_mcHaveMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_mgHaveMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_boughtDrink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_userHaveMoney);
            this.Controls.Add(this.button_returnChange);
            this.Controls.Add(this.button_insertMoney);
            this.Controls.Add(this.textBox_insertedMoney);
            this.Controls.Add(this.label_machineStatus);
            this.Controls.Add(this.button_drinkPriceChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_drinkPriceChange);
            this.Controls.Add(this.button_changeSupply);
            this.Controls.Add(this.button_profitGain);
            this.Controls.Add(this.button_drinkSupply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_userMoney);
            this.Controls.Add(this.label_manager);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_callManager);
            this.Controls.Add(this.label_drinkPrice);
            this.Controls.Add(this.button_drink);
            this.Controls.Add(this.splitter1);
            this.Name = "VendingMachineForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_callManager;
        private System.Windows.Forms.Label label_drinkPrice;
        private System.Windows.Forms.Button button_drink;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_manager;
        private System.Windows.Forms.Label label_userMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_drinkSupply;
        private System.Windows.Forms.Button button_profitGain;
        private System.Windows.Forms.Button button_changeSupply;
        private System.Windows.Forms.TextBox textBox_drinkPriceChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_drinkPriceChange;
        private System.Windows.Forms.Label label_machineStatus;
        private System.Windows.Forms.TextBox textBox_insertedMoney;
        private System.Windows.Forms.Button button_insertMoney;
        private System.Windows.Forms.Button button_returnChange;
        private System.Windows.Forms.TextBox textBox_userHaveMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_boughtDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_mgHaveMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_mcHaveMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_mcDrinkCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_returnDrink;
    }
}

