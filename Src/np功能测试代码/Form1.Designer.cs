﻿namespace 功能测试代码
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn登录测试 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn登录测试
            // 
            this.btn登录测试.Location = new System.Drawing.Point(12, 33);
            this.btn登录测试.Name = "btn登录测试";
            this.btn登录测试.Size = new System.Drawing.Size(75, 23);
            this.btn登录测试.TabIndex = 0;
            this.btn登录测试.Text = "登录测试";
            this.btn登录测试.UseVisualStyleBackColor = true;
            this.btn登录测试.Click += new System.EventHandler(this.btn登录测试_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn登录测试);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn登录测试;
    }
}

