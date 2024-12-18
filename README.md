# FilmeAPI
API de filmes desenvolvida para a matéria de Gestão da Configuração II.

## Como executar o projeto?
**Necessário ter o .Net 8 instalado em sua máquina**
### No Visual Studio
- Clone este repositório.
- Abra o projeto na IDE e pressione F5 para executar.
### No Visual Studio Code
- Clone este repositório
- Abra o projeto no editor de código e no terminal execute o comando _dotnet run_

Após executar o projeto, utilize ferramentas como o Swagger ou o Postman para acessar os endpoints.


markdown
Copiar código
## Configuração de Infraestrutura com Vagrant

Este projeto configura duas máquinas virtuais (VMs) para executar uma aplicação .NET 9 e testar uma rota HTTP.

### Requisitos

- [Vagrant](https://www.vagrantup.com/)
- [VirtualBox](https://www.virtualbox.org/)

### Estrutura

- **VM1**: 1024 MB, IP: `192.168.56.101` (para testes).  
- **VM2**: 2048 MB, IP: `192.168.56.102` (hospeda a aplicação .NET 9).

### Passos para Configuração

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/luisaferreira/Filmes.git
   cd Filmes
2. **Suba as máquinas virtuais**:
    ```bash
    vagrant up
3. **Acesse as VMs (se necessário)**:
    ```bash
    VM1: vagrant ssh vm1
    VM2: vagrant ssh vm2
4. **Acesse a aplicação: http://192.168.56.102:5000**.

### Testando a Rota GET
1. **Acesse a VM1**:
    ```bash
    vagrant ssh vm1
2. **Teste a rota com curl**:
    ```bash
    curl http://192.168.56.102:5000/Filme

## Workflow
Tendo em vista que o projeto é uma API simples administrada por uma única pessoa o fluxo de trabalho escolhido foi o Github Flow.