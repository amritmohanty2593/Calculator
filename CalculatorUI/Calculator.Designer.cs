namespace CalculatorUI
{
    partial class Calculator
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
            TreeNode treeNode1 = new TreeNode("Calculator");
            TreeNode treeNode2 = new TreeNode("Standard");
            TreeNode treeNode3 = new TreeNode("Scientific");
            TreeNode treeNode4 = new TreeNode("Graphic");
            TreeNode treeNode5 = new TreeNode("Programmer");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            btnPercentage = new Button();
            btnCe = new Button();
            btnC = new Button();
            btnClear = new Button();
            btnDivision = new Button();
            btnSqureRoot = new Button();
            btnXSquare = new Button();
            btnOneDivideByX = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnMinus = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnPlus = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnEqual = new Button();
            button22 = new Button();
            btn0 = new Button();
            btnPlusMinus = new Button();
            txtCalculations = new TextBox();
            lblOption = new Label();
            lblCalculatorType = new Label();
            lblHistoryTab = new Label();
            lblMemory = new Label();
            txtHistoryNMemory = new TextBox();
            lblOutput = new Label();
            lblClearHistory = new Label();
            trvCalcList = new TreeView();
            SuspendLayout();
            // 
            // btnPercentage
            // 
            btnPercentage.BackColor = Color.Gainsboro;
            btnPercentage.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPercentage.Location = new Point(3, 176);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(94, 56);
            btnPercentage.TabIndex = 0;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = false;
            btnPercentage.Click += OnClickCommonArtSymbol;
            // 
            // btnCe
            // 
            btnCe.BackColor = Color.Gainsboro;
            btnCe.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCe.Location = new Point(97, 176);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(94, 56);
            btnCe.TabIndex = 1;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnResetClick;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Gainsboro;
            btnC.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(191, 176);
            btnC.Name = "btnC";
            btnC.Size = new Size(94, 56);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnResetClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Font = new Font("Wingdings", 18F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnClear.Location = new Point(285, 176);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 56);
            btnClear.TabIndex = 3;
            btnClear.Text = "";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.Gainsboro;
            btnDivision.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(285, 231);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(94, 56);
            btnDivision.TabIndex = 7;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += OnClickArithmaticSymbol;
            // 
            // btnSqureRoot
            // 
            btnSqureRoot.BackColor = Color.Gainsboro;
            btnSqureRoot.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSqureRoot.Location = new Point(191, 231);
            btnSqureRoot.Name = "btnSqureRoot";
            btnSqureRoot.Size = new Size(94, 56);
            btnSqureRoot.TabIndex = 6;
            btnSqureRoot.Text = "²√x";
            btnSqureRoot.UseVisualStyleBackColor = false;
            btnSqureRoot.Click += OnClickCommonArtSymbol;
            // 
            // btnXSquare
            // 
            btnXSquare.BackColor = Color.Gainsboro;
            btnXSquare.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXSquare.Location = new Point(97, 231);
            btnXSquare.Name = "btnXSquare";
            btnXSquare.Size = new Size(94, 56);
            btnXSquare.TabIndex = 5;
            btnXSquare.Text = "×²";
            btnXSquare.UseVisualStyleBackColor = false;
            btnXSquare.Click += OnClickCommonArtSymbol;
            // 
            // btnOneDivideByX
            // 
            btnOneDivideByX.BackColor = Color.Gainsboro;
            btnOneDivideByX.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOneDivideByX.Location = new Point(3, 231);
            btnOneDivideByX.Name = "btnOneDivideByX";
            btnOneDivideByX.Size = new Size(94, 56);
            btnOneDivideByX.TabIndex = 4;
            btnOneDivideByX.Text = "1/x";
            btnOneDivideByX.UseVisualStyleBackColor = false;
            btnOneDivideByX.Click += OnClickCommonArtSymbol;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Gainsboro;
            btnMultiply.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(285, 287);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 56);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += OnClickArithmaticSymbol;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.Gainsboro;
            btnNine.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(191, 287);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(94, 56);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += OnClickNumbers;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.Gainsboro;
            btnEight.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(97, 287);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(94, 56);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += OnClickNumbers;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.Gainsboro;
            btnSeven.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(3, 287);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(94, 56);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += OnClickNumbers;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Gainsboro;
            btnMinus.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(285, 342);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 56);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OnClickArithmaticSymbol;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.Gainsboro;
            btnSix.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(191, 342);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(94, 56);
            btnSix.TabIndex = 14;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += OnClickNumbers;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.Gainsboro;
            btnFive.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(97, 342);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(94, 56);
            btnFive.TabIndex = 13;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += OnClickNumbers;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.Gainsboro;
            btnFour.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(3, 342);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(94, 56);
            btnFour.TabIndex = 12;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += OnClickNumbers;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Gainsboro;
            btnPlus.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(285, 396);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 56);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += OnClickArithmaticSymbol;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.Gainsboro;
            btnThree.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(191, 396);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(94, 56);
            btnThree.TabIndex = 18;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += OnClickNumbers;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.Gainsboro;
            btnTwo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(97, 396);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(94, 56);
            btnTwo.TabIndex = 17;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += OnClickNumbers;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.Gainsboro;
            btnOne.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(3, 396);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(94, 56);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += OnClickNumbers;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(285, 452);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(94, 56);
            btnEqual.TabIndex = 23;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Gainsboro;
            button22.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.Location = new Point(191, 452);
            button22.Name = "button22";
            button22.Size = new Size(94, 56);
            button22.TabIndex = 22;
            button22.Text = ".";
            button22.UseVisualStyleBackColor = false;
            button22.Click += OnClickNumbers;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gainsboro;
            btn0.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(97, 452);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 56);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += OnClickNumbers;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.Gainsboro;
            btnPlusMinus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlusMinus.Location = new Point(3, 452);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(94, 56);
            btnPlusMinus.TabIndex = 20;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += OnClickCommonArtSymbol;
            // 
            // txtCalculations
            // 
            txtCalculations.BackColor = SystemColors.ControlDarkDark;
            txtCalculations.BorderStyle = BorderStyle.None;
            txtCalculations.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCalculations.ForeColor = SystemColors.Window;
            txtCalculations.Location = new Point(3, 95);
            txtCalculations.MaxLength = 10;
            txtCalculations.Name = "txtCalculations";
            txtCalculations.ReadOnly = true;
            txtCalculations.Size = new Size(376, 56);
            txtCalculations.TabIndex = 24;
            txtCalculations.Text = "0";
            txtCalculations.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.ForeColor = SystemColors.ButtonHighlight;
            lblOption.Location = new Point(3, 9);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(44, 46);
            lblOption.TabIndex = 25;
            lblOption.Text = "≡";
            lblOption.Click += lblOption_Click;
            // 
            // lblCalculatorType
            // 
            lblCalculatorType.AutoSize = true;
            lblCalculatorType.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculatorType.ForeColor = SystemColors.ControlLightLight;
            lblCalculatorType.Location = new Point(42, 19);
            lblCalculatorType.Name = "lblCalculatorType";
            lblCalculatorType.Size = new Size(112, 32);
            lblCalculatorType.TabIndex = 26;
            lblCalculatorType.Text = "Standard";
            // 
            // lblHistoryTab
            // 
            lblHistoryTab.AutoSize = true;
            lblHistoryTab.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryTab.ForeColor = SystemColors.ControlLightLight;
            lblHistoryTab.Location = new Point(405, 20);
            lblHistoryTab.Name = "lblHistoryTab";
            lblHistoryTab.Size = new Size(85, 30);
            lblHistoryTab.TabIndex = 27;
            lblHistoryTab.Text = "History";
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemory.ForeColor = SystemColors.ControlLightLight;
            lblMemory.Location = new Point(517, 19);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(97, 30);
            lblMemory.TabIndex = 28;
            lblMemory.Text = "Memory";
            // 
            // txtHistoryNMemory
            // 
            txtHistoryNMemory.BackColor = SystemColors.ControlDarkDark;
            txtHistoryNMemory.BorderStyle = BorderStyle.None;
            txtHistoryNMemory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHistoryNMemory.ForeColor = SystemColors.Window;
            txtHistoryNMemory.Location = new Point(405, 65);
            txtHistoryNMemory.Multiline = true;
            txtHistoryNMemory.Name = "txtHistoryNMemory";
            txtHistoryNMemory.Size = new Size(313, 414);
            txtHistoryNMemory.TabIndex = 29;
            txtHistoryNMemory.Text = "There's no history yet";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = SystemColors.ControlLightLight;
            lblOutput.Location = new Point(214, 51);
            lblOutput.MaximumSize = new Size(200, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 28);
            lblOutput.TabIndex = 30;
            // 
            // lblClearHistory
            // 
            lblClearHistory.AutoSize = true;
            lblClearHistory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClearHistory.ForeColor = SystemColors.ButtonHighlight;
            lblClearHistory.Location = new Point(662, 465);
            lblClearHistory.Name = "lblClearHistory";
            lblClearHistory.Size = new Size(48, 32);
            lblClearHistory.TabIndex = 31;
            lblClearHistory.Text = "🚰";
            lblClearHistory.Click += lblClearHistory_Click;
            // 
            // trvCalcList
            // 
            trvCalcList.BackColor = Color.Gainsboro;
            trvCalcList.BorderStyle = BorderStyle.None;
            trvCalcList.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trvCalcList.ForeColor = Color.Black;
            trvCalcList.Location = new Point(2, 54);
            trvCalcList.Name = "trvCalcList";
            treeNode1.Name = "Calculator";
            treeNode1.Text = "Calculator";
            treeNode2.Name = "Standard";
            treeNode2.Text = "Standard";
            treeNode3.Name = "Scientific";
            treeNode3.Text = "Scientific";
            treeNode4.Name = "Graphic";
            treeNode4.Text = "Graphic";
            treeNode5.Name = "Programmer";
            treeNode5.Text = "Programmer";
            trvCalcList.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
            trvCalcList.Size = new Size(206, 448);
            trvCalcList.TabIndex = 32;
            trvCalcList.Click += OnClickCommonArtSymbol;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(722, 511);
            Controls.Add(trvCalcList);
            Controls.Add(lblClearHistory);
            Controls.Add(lblOutput);
            Controls.Add(txtHistoryNMemory);
            Controls.Add(lblMemory);
            Controls.Add(lblHistoryTab);
            Controls.Add(lblCalculatorType);
            Controls.Add(lblOption);
            Controls.Add(txtCalculations);
            Controls.Add(btnEqual);
            Controls.Add(button22);
            Controls.Add(btn0);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnMinus);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDivision);
            Controls.Add(btnSqureRoot);
            Controls.Add(btnXSquare);
            Controls.Add(btnOneDivideByX);
            Controls.Add(btnClear);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Controls.Add(btnPercentage);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPercentage;
        private Button btnCe;
        private Button btnC;
        private Button btnClear;
        private Button btnDivision;
        private Button btnSqureRoot;
        private Button btnXSquare;
        private Button btnOneDivideByX;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnMinus;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnPlus;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnEqual;
        private Button button22;
        private Button btn0;
        private Button btnPlusMinus;
        private TextBox txtCalculations;
        private Label lblOption;
        private Label lblCalculatorType;
        private Label lblHistoryTab;
        private Label lblMemory;
        private TextBox txtHistoryNMemory;
        private Label lblOutput;
        private Label lblClearHistory;
        private TreeView trvCalcList;
    }
}