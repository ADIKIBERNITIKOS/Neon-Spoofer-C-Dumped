

using Guna.UI2.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Login : Form
  {
    public static api KeyAuthApp = new api("Neon Woofer", "TWErYrxC8o", "a6da2ca935e00d5b70a059db501b06dc06715714bd4c75e96aaf9d2545dd6783", "1.0");
    private IContainer components = (IContainer) null;
    private SiticoneDragControl siticoneDragControl1;
    private SiticoneControlBox siticoneControlBox1;
    private SiticoneControlBox siticoneControlBox2;
    private SiticoneTransition siticoneTransition1;
    private Label label1;
    private Label label2;
    private SiticoneShadowForm siticoneShadowForm;
    private Guna2TextBox Key;
    private Label label5;
    private Guna2TextBox Password;
    private Label label4;
    private Label label3;
    private Guna2TextBox Username;
    private SiticoneButton BRedeem;
    private SiticoneButton BLogin;

    public Login() => this.InitializeComponent();

    private void siticoneControlBox1_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Login_Load(object sender, EventArgs e)
    {
      Login.KeyAuthApp.init();
      if (Login.KeyAuthApp.response.message == "invalidver")
      {
        if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
        {
          switch (MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo))
          {
            case DialogResult.Yes:
              Process.Start(Login.KeyAuthApp.app_data.downloadLink);
              Environment.Exit(0);
              break;
            case DialogResult.No:
              WebClient webClient = new WebClient();
              string fileName = Application.ExecutablePath.Replace(".exe", "-" + Login.random_string() + ".exe");
              webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, fileName);
              Process.Start(fileName);
              Process.Start(new ProcessStartInfo()
              {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
              });
              Environment.Exit(0);
              break;
            default:
              int num1 = (int) MessageBox.Show("Invalid option");
              Environment.Exit(0);
              break;
          }
        }
        int num2 = (int) MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
        Thread.Sleep(2500);
        Environment.Exit(0);
      }
      if (!Login.KeyAuthApp.response.success)
      {
        int num = (int) MessageBox.Show(Login.KeyAuthApp.response.message);
        Environment.Exit(0);
      }
      Login.KeyAuthApp.check();
    }

    private static string random_string()
    {
      string str = (string) null;
      Random random = new Random();
      for (int index = 0; index < 5; ++index)
        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
      return str;
    }

    private void UpgradeBtn_Click(object sender, EventArgs e) => Login.KeyAuthApp.upgrade(this.Username.Text, this.Key.Text);

    private void LoginBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.login(this.Username.Text, this.Password.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void RgstrBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.register(this.Username.Text, this.Password.Text, this.Key.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void LicBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.license(this.Key.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void siticoneLabel1_Click(object sender, EventArgs e)
    {
    }

    private void key_TextChanged(object sender, EventArgs e)
    {
    }

    private void BLogin_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.login(this.Username.Text, this.Password.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void BPassword_Click(object sender, EventArgs e)
    {
    }

    private void BKey_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.register(this.Username.Text, this.Password.Text, this.Key.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void siticoneButton2_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.login(this.Username.Text, this.Password.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    private void siticoneButton1_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.register(this.Username.Text, this.Password.Text, this.Key.Text);
      if (!Login.KeyAuthApp.response.success)
        return;
      new Main().Show();
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.components != null ? 1 : 0)) != 0)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      Animation animation = new Animation();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Login));
      this.siticoneDragControl1 = new SiticoneDragControl(this.components);
      this.siticoneControlBox1 = new SiticoneControlBox();
      this.siticoneControlBox2 = new SiticoneControlBox();
      this.siticoneTransition1 = new SiticoneTransition();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.Password = new Guna2TextBox();
      this.label5 = new Label();
      this.Key = new Guna2TextBox();
      this.Username = new Guna2TextBox();
      this.BLogin = new SiticoneButton();
      this.BRedeem = new SiticoneButton();
      this.siticoneShadowForm = new SiticoneShadowForm(this.components);
      this.SuspendLayout();
      this.siticoneDragControl1.TargetControl = (Control) this;
      this.siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox1.BorderRadius = 10;
      this.siticoneTransition1.SetDecoration((Control) this.siticoneControlBox1, DecorationType.None);
      this.siticoneControlBox1.FillColor = Color.Black;
      this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
      this.siticoneControlBox1.HoveredState.IconColor = Color.White;
      this.siticoneControlBox1.HoveredState.Parent = (ControlBox) this.siticoneControlBox1;
      this.siticoneControlBox1.IconColor = Color.White;
      this.siticoneControlBox1.Location = new Point(246, 4);
      this.siticoneControlBox1.Name = "siticoneControlBox1";
      this.siticoneControlBox1.ShadowDecoration.Parent = (Control) this.siticoneControlBox1;
      this.siticoneControlBox1.Size = new Size(45, 29);
      this.siticoneControlBox1.TabIndex = 1;
      this.siticoneControlBox1.Click += new EventHandler(this.siticoneControlBox1_Click);
      this.siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox2.BorderRadius = 10;
      this.siticoneControlBox2.ControlBoxType = ControlBoxType.MinimizeBox;
      this.siticoneTransition1.SetDecoration((Control) this.siticoneControlBox2, DecorationType.None);
      this.siticoneControlBox2.FillColor = Color.Black;
      this.siticoneControlBox2.HoveredState.Parent = (ControlBox) this.siticoneControlBox2;
      this.siticoneControlBox2.IconColor = Color.White;
      this.siticoneControlBox2.Location = new Point(200, 4);
      this.siticoneControlBox2.Name = "siticoneControlBox2";
      this.siticoneControlBox2.ShadowDecoration.Parent = (Control) this.siticoneControlBox2;
      this.siticoneControlBox2.Size = new Size(45, 29);
      this.siticoneControlBox2.TabIndex = 2;
      this.siticoneTransition1.AnimationType = AnimationType.Rotate;
      this.siticoneTransition1.Cursor = (Cursor) null;
      animation.AnimateOnlyDifferences = true;
      animation.BlindCoeff = (PointF) componentResourceManager.GetObject("animation2.BlindCoeff");
      animation.LeafCoeff = 0.0f;
      animation.MaxTime = 1f;
      animation.MinTime = 0.0f;
      animation.MosaicCoeff = (PointF) componentResourceManager.GetObject("animation2.MosaicCoeff");
      animation.MosaicShift = (PointF) componentResourceManager.GetObject("animation2.MosaicShift");
      animation.MosaicSize = 0;
      animation.Padding = new Padding(50);
      animation.RotateCoeff = 1f;
      animation.RotateLimit = 0.0f;
      animation.ScaleCoeff = (PointF) componentResourceManager.GetObject("animation2.ScaleCoeff");
      animation.SlideCoeff = (PointF) componentResourceManager.GetObject("animation2.SlideCoeff");
      animation.TimeCoeff = 0.0f;
      animation.TransparencyCoeff = 1f;
      this.siticoneTransition1.DefaultAnimation = animation;
      this.label1.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label1, DecorationType.None);
      this.label1.Font = new Font("Segoe UI Light", 10f);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(-1, 136);
      this.label1.Name = "label1";
      this.label1.Size = new Size(0, 19);
      this.label1.TabIndex = 22;
      this.label2.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label2, DecorationType.None);
      this.label2.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.ButtonFace;
      this.label2.Location = new Point(11, 14);
      this.label2.Margin = new Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(94, 19);
      this.label2.TabIndex = 27;
      this.label2.Text = "Neon Woofer";
      this.label3.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label3, DecorationType.None);
      this.label3.Font = new Font("MS UI Gothic", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.FromArgb(192, 0, 0);
      this.label3.Location = new Point(105, 49);
      this.label3.Name = "label3";
      this.label3.Size = new Size(89, 15);
      this.label3.TabIndex = 36;
      this.label3.Text = "USERNAME";
      this.label4.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label4, DecorationType.None);
      this.label4.Font = new Font("MS UI Gothic", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.FromArgb(192, 0, 0);
      this.label4.Location = new Point(105, 122);
      this.label4.Name = "label4";
      this.label4.Size = new Size(92, 15);
      this.label4.TabIndex = 37;
      this.label4.Text = "PASSWORD";
      this.Password.Animated = true;
      this.Password.AutoRoundedCorners = true;
      this.Password.BorderRadius = 16;
      this.Password.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.Password, DecorationType.None);
      this.Password.DefaultText = "";
      this.Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.Password.FillColor = Color.FromArgb(8, 9, 10);
      this.Password.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Password.Font = new Font("Segoe UI", 9f);
      this.Password.ForeColor = Color.Red;
      this.Password.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Password.Location = new Point(30, 150);
      this.Password.Name = "Password";
      this.Password.PasswordChar = char.MinValue;
      this.Password.PlaceholderText = "";
      this.Password.SelectedText = "";
      this.Password.Size = new Size(247, 34);
      this.Password.TabIndex = 38;
      this.label5.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label5, DecorationType.None);
      this.label5.Font = new Font("MS UI Gothic", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.FromArgb(192, 0, 0);
      this.label5.Location = new Point(105, 197);
      this.label5.Name = "label5";
      this.label5.Size = new Size(71, 15);
      this.label5.TabIndex = 39;
      this.label5.Text = "LICENSE";
      this.Key.Animated = true;
      this.Key.AutoRoundedCorners = true;
      this.Key.BorderRadius = 16;
      this.Key.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.Key, DecorationType.None);
      this.Key.DefaultText = "";
      this.Key.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.Key.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.Key.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.Key.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.Key.FillColor = Color.FromArgb(8, 9, 10);
      this.Key.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Key.Font = new Font("Segoe UI", 9f);
      this.Key.ForeColor = Color.Red;
      this.Key.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Key.Location = new Point(30, 225);
      this.Key.Name = "Key";
      this.Key.PasswordChar = char.MinValue;
      this.Key.PlaceholderText = "";
      this.Key.SelectedText = "";
      this.Key.Size = new Size(247, 34);
      this.Key.TabIndex = 40;
      this.Username.Animated = true;
      this.Username.AutoRoundedCorners = true;
      this.Username.BorderRadius = 16;
      this.Username.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.Username, DecorationType.None);
      this.Username.DefaultText = "";
      this.Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.Username.FillColor = Color.FromArgb(8, 9, 10);
      this.Username.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Username.Font = new Font("Segoe UI", 9f);
      this.Username.ForeColor = Color.Red;
      this.Username.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.Username.Location = new Point(30, 76);
      this.Username.Name = "Username";
      this.Username.PasswordChar = char.MinValue;
      this.Username.PlaceholderText = "";
      this.Username.SelectedText = "";
      this.Username.Size = new Size(247, 34);
      this.Username.TabIndex = 43;
      this.BLogin.BorderColor = Color.Red;
      this.BLogin.BorderRadius = 4;
      this.BLogin.BorderThickness = 2;
      this.BLogin.CheckedState.Parent = (CustomButtonBase) this.BLogin;
      this.BLogin.CustomBorderColor = Color.White;
      this.BLogin.CustomImages.Parent = (CustomButtonBase) this.BLogin;
      this.siticoneTransition1.SetDecoration((Control) this.BLogin, DecorationType.None);
      this.BLogin.FillColor = Color.Black;
      this.BLogin.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BLogin.ForeColor = Color.White;
      this.BLogin.HoveredState.Parent = (CustomButtonBase) this.BLogin;
      this.BLogin.Location = new Point(54, 265);
      this.BLogin.Name = "BLogin";
      this.BLogin.PressedColor = Color.FromArgb(26, 32, 54);
      this.BLogin.ShadowDecoration.Parent = (Control) this.BLogin;
      this.BLogin.Size = new Size(191, 38);
      this.BLogin.TabIndex = 73;
      this.BLogin.Text = nameof (Login);
      this.BLogin.Click += new EventHandler(this.siticoneButton2_Click);
      this.BRedeem.BorderColor = Color.Red;
      this.BRedeem.BorderRadius = 4;
      this.BRedeem.BorderThickness = 2;
      this.BRedeem.CheckedState.Parent = (CustomButtonBase) this.BRedeem;
      this.BRedeem.CustomBorderColor = Color.White;
      this.BRedeem.CustomImages.Parent = (CustomButtonBase) this.BRedeem;
      this.siticoneTransition1.SetDecoration((Control) this.BRedeem, DecorationType.None);
      this.BRedeem.FillColor = Color.Black;
      this.BRedeem.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BRedeem.ForeColor = Color.White;
      this.BRedeem.HoveredState.Parent = (CustomButtonBase) this.BRedeem;
      this.BRedeem.Location = new Point(54, 309);
      this.BRedeem.Name = "BRedeem";
      this.BRedeem.PressedColor = Color.FromArgb(26, 32, 54);
      this.BRedeem.ShadowDecoration.Parent = (Control) this.BRedeem;
      this.BRedeem.Size = new Size(191, 38);
      this.BRedeem.TabIndex = 74;
      this.BRedeem.Text = "Redeem";
      this.BRedeem.Click += new EventHandler(this.siticoneButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.Disable;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(295, 370);
      this.Controls.Add((Control) this.BRedeem);
      this.Controls.Add((Control) this.BLogin);
      this.Controls.Add((Control) this.Username);
      this.Controls.Add((Control) this.Key);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.Password);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.siticoneControlBox2);
      this.Controls.Add((Control) this.siticoneControlBox1);
      this.siticoneTransition1.SetDecoration((Control) this, DecorationType.BottomMirror);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Login);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "NEON WOOFER";
      this.TransparencyKey = Color.Maroon;
      this.Load += new EventHandler(this.Login_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
