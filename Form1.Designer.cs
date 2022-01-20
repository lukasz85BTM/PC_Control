
namespace PC_Control
{
    partial class pccontrol
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pccontrol));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MachineName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.ProcessorCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wersja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bitProcess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.systemPlatform = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.versionWord = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPM = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBios = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBM = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa komputera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Użytkownik:";
            // 
            // MachineName
            // 
            this.MachineName.AutoSize = true;
            this.MachineName.Location = new System.Drawing.Point(133, 99);
            this.MachineName.Name = "MachineName";
            this.MachineName.Size = new System.Drawing.Size(10, 13);
            this.MachineName.TabIndex = 1;
            this.MachineName.Text = "-";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(133, 122);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(10, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "-";
            // 
            // ProcessorCount
            // 
            this.ProcessorCount.AutoSize = true;
            this.ProcessorCount.Location = new System.Drawing.Point(163, 57);
            this.ProcessorCount.Name = "ProcessorCount";
            this.ProcessorCount.Size = new System.Drawing.Size(10, 13);
            this.ProcessorCount.TabIndex = 1;
            this.ProcessorCount.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ilość rdzeni :";
            // 
            // wersja
            // 
            this.wersja.AutoSize = true;
            this.wersja.Location = new System.Drawing.Point(163, 129);
            this.wersja.Name = "wersja";
            this.wersja.Size = new System.Drawing.Size(10, 13);
            this.wersja.TabIndex = 1;
            this.wersja.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "64 Bit OS :";
            // 
            // bitProcess
            // 
            this.bitProcess.AutoSize = true;
            this.bitProcess.Location = new System.Drawing.Point(163, 153);
            this.bitProcess.Name = "bitProcess";
            this.bitProcess.Size = new System.Drawing.Size(10, 13);
            this.bitProcess.TabIndex = 1;
            this.bitProcess.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "64 Bit Process :";
            // 
            // systemPlatform
            // 
            this.systemPlatform.AutoSize = true;
            this.systemPlatform.Location = new System.Drawing.Point(133, 53);
            this.systemPlatform.Name = "systemPlatform";
            this.systemPlatform.Size = new System.Drawing.Size(10, 13);
            this.systemPlatform.TabIndex = 1;
            this.systemPlatform.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Platforma Systemu :";
            // 
            // versionWord
            // 
            this.versionWord.AutoSize = true;
            this.versionWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versionWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.versionWord.Location = new System.Drawing.Point(133, 30);
            this.versionWord.Name = "versionWord";
            this.versionWord.Size = new System.Drawing.Size(10, 13);
            this.versionWord.TabIndex = 1;
            this.versionWord.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "System operacyjny :";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(133, 76);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(10, 13);
            this.version.TabIndex = 1;
            this.version.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Wersja Systemu :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblPM);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblBios);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblBM);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblHDD);
            this.groupBox2.Location = new System.Drawing.Point(16, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje dodatkowe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pamięć fizyczna :";
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Location = new System.Drawing.Point(133, 98);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(10, 13);
            this.lblPM.TabIndex = 1;
            this.lblPM.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Dostępna pamięć :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "BIOS Producent :";
            // 
            // lblBios
            // 
            this.lblBios.AutoSize = true;
            this.lblBios.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBios.Location = new System.Drawing.Point(133, 75);
            this.lblBios.Name = "lblBios";
            this.lblBios.Size = new System.Drawing.Size(10, 13);
            this.lblBios.TabIndex = 1;
            this.lblBios.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Producent Płyty :";
            // 
            // lblBM
            // 
            this.lblBM.AutoSize = true;
            this.lblBM.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBM.Location = new System.Drawing.Point(133, 52);
            this.lblBM.Name = "lblBM";
            this.lblBM.Size = new System.Drawing.Size(10, 13);
            this.lblBM.TabIndex = 1;
            this.lblBM.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "HDD Serial nummer :";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Location = new System.Drawing.Point(133, 29);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(10, 13);
            this.lblHDD.TabIndex = 1;
            this.lblHDD.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "INFORMACJE O SPRZĘCIE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Producent procesora CPU :";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCM.Location = new System.Drawing.Point(163, 33);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(10, 13);
            this.lblCM.TabIndex = 1;
            this.lblCM.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "ID Procesora :";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(163, 177);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(10, 13);
            this.lblPid.TabIndex = 1;
            this.lblPid.Text = "-";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(163, 81);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(10, 13);
            this.lblCS.TabIndex = 1;
            this.lblCS.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 81);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Prędkość CPU:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.userName);
            this.groupBox3.Controls.Add(this.version);
            this.groupBox3.Controls.Add(this.MachineName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.versionWord);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.systemPlatform);
            this.groupBox3.Location = new System.Drawing.Point(16, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 174);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacje o Systemie";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Czas pracy Systemu :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "-";
            this.label22.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.bitProcess);
            this.groupBox4.Controls.Add(this.lblCM);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.wersja);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ProcessorCount);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lblPid);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.lblCS);
            this.groupBox4.Location = new System.Drawing.Point(16, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 210);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procesor CPU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Użycie Procesora CPU :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pccontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 607);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pccontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Control Easy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label MachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProcessorCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wersja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bitProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label systemPlatform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label versionWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
    }
}

