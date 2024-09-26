using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WebCrawler_JUSBrasil
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string email = "seu-email-de-acesso-ao-jus-br-aqui"; // email para login 
            string senha = "sua-senha-aqui"; // coloque sua senha 
            string cpf = txtCpf.Text; // pesquisa CPF

            // chama o script Python para resolver o CAPTCHA
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"python"; // certifica de que o Python está no PATH
            start.Arguments = @"Caminho\do-arquivo\aqui\CaptchaSolver.py"; // caminho do script Python
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            using (Process process = Process.Start(start))
            {
                process.WaitForExit(); // aguarda execução do Python
            }

            // inicia o driver após o CAPTCHA ser resolvido
            InitializeWebDriver(email, senha, cpf);
        }

        private void InitializeWebDriver(string email, string senha, string cpf)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-popup-blocking");

            driver = new ChromeDriver(@"Caminho\do\chromedriver.exe", chromeOptions); // ajusta caminho para o ChromeDriver

            try
            {
                driver.Navigate().GoToUrl("https://www.jusbrasil.com.br/login");

                // preenche campo de email
                var inputEmail = driver.FindElement(By.Id("FormFieldset-email"));
                inputEmail.SendKeys(email);
                var botaoContinuar = driver.FindElement(By.CssSelector("button[data-testid='submit-button']"));
                botaoContinuar.Click();
                Thread.Sleep(4000);

                // preenche campo de senha
                var inputSenha = driver.FindElement(By.Id("FormFieldset-password"));
                inputSenha.SendKeys(senha);
                var botaoEntrar = driver.FindElement(By.CssSelector("button[data-testid='submit-button']"));
                botaoEntrar.Click();
                Thread.Sleep(5000);

                // preenche campo de CPF
                var inputCpf = driver.FindElement(By.CssSelector("input[placeholder='Digite um CPF, nome ou número de processo']"));
                inputCpf.SendKeys(cpf);
                var botaoPesquisar = driver.FindElement(By.CssSelector("button[type='submit']"));
                botaoPesquisar.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                driver?.Quit();
            }
        }
    }
}