﻿namespace chaos_game
{
    partial class mainGamePainting
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPaintPanel = new System.Windows.Forms.Panel();
            // 
            // mainPaintPanel
            // 
            this.mainPaintPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPaintPanel.Name = "mainPaintPanel";
            this.mainPaintPanel.Size = new System.Drawing.Size(200, 100);
            this.mainPaintPanel.TabIndex = 0;
            this.mainPaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);

        }

        #endregion

        private System.Windows.Forms.Panel mainPaintPanel;
    }
}
