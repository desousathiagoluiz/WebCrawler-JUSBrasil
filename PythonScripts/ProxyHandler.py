import random

class ProxyHandler:
    def __init__(self):
        self.proxies = self.load_proxies()

    def load_proxies(self):
        # carrega proxie de um arquivo ou defini manualmente
        return [
            'http://proxy1:port',
            'http://proxy2:port',
            # adiciona mais proxies aqui
        ]

    def get_random_proxy(self):
        return random.choice(self.proxies)

if __name__ == "__main__":
    handler = ProxyHandler()
    print(handler.get_random_proxy())  # para teste se o proxy está funcionando