﻿namespace GasCardMgrTool
{
    partial class FormMain
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
            this.buttonMakefMgr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMakefMgr
            // 
            this.buttonMakefMgr.Location = new System.Drawing.Point(12, 12);
            this.buttonMakefMgr.Name = "buttonMakefMgr";
            this.buttonMakefMgr.Size = new System.Drawing.Size(75, 23);
            this.buttonMakefMgr.TabIndex = 0;
            this.buttonMakefMgr.Text = "生产管理";
            this.buttonMakefMgr.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 454);
            this.Controls.Add(this.buttonMakefMgr);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMakefMgr;
    }
}

