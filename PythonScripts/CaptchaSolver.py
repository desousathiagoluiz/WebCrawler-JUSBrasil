from selenium import webdriver
from ProxyHandler import ProxyHandler
import sys

def solve_captcha():
    proxy_handler = ProxyHandler()
    proxy = proxy_handler.get_random_proxy()

    options = webdriver.ChromeOptions()
    options.add_argument(f'--proxy-server={proxy}')  # usa proxy
    options.add_argument("--start-maximized")

    # inicia o chrome com o proxy
    driver = webdriver.Chrome(options=options)
    
    # acessa  URL do crawler
    driver.get('https://www.jusbrasil.com.br/login')

    # espera resolver CAPTCHA
    input("Resolva o CAPTCHA e pressione Enter...")

    # retorna ao driver para continuar
    return driver

if __name__ == "__main__":
    driver = solve_captcha()
    # resolveu o CAPTCHA, você pode continuar a lógica de pesquisa
    sys.exit(0)