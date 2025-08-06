# Sistema de Estacionamento de Veículos

Um sistema de gerenciamento de estacionamento desenvolvido em C# .NET 9.0 que permite cadastrar, listar e remover veículos do estacionamento.

## 📋 Funcionalidades

- **Cadastrar Veículo**: Adiciona um novo veículo ao estacionamento
- **Remover Veículo**: Remove um veículo através da placa
- **Listar Veículos**: Exibe todos os veículos estacionados
- **Validação de Placa**: Sistema de validação para placas brasileiras (padrão Mercosul)

## 🚗 Tipos de Veículos Suportados

- Carro
- Moto
- Bicicleta

## 🛠️ Tecnologias Utilizadas

- **C# 9.0**
- **.NET 9.0**
- **Console Application**

## 📁 Estrutura do Projeto

```
EstacionamentoVeiculos/
├── Handlers/
│   └── Handler.cs              # Controlador principal das operações
├── Models/
│   └── Veiculo.cs             # Modelo de dados do veículo
├── Services/
│   └── Estacionamento.cs      # Lógica de negócio do estacionamento
├── Utils/
│   └── ValidadorPlaca.cs      # Utilitário para validação de placas
├── Program.cs                 # Ponto de entrada da aplicação
├── EstacionamentoVeiculos.csproj
└── EstacionamentoVeiculos.sln
```

## 🚀 Como Executar

### Pré-requisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) instalado
- Visual Studio 2022, Visual Studio Code ou qualquer IDE compatível com .NET

### Passos para Execução

1. **Clone ou baixe o projeto**
   ```bash
   git clone <url-do-repositorio>
   cd EstacionamentoVeiculos
   ```

2. **Restaure as dependências**
   ```bash
   dotnet restore
   ```

3. **Execute o projeto**
   ```bash
   dotnet run
   ```

### Alternativa com Visual Studio

1. Abra o arquivo `EstacionamentoVeiculos.sln` no Visual Studio
2. Pressione `F5` ou clique em "Iniciar" para executar

## 📖 Como Usar

Ao executar o programa, você verá um menu com as seguintes opções:

```
Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

### 1. Cadastrar Veículo
- Selecione a opção `1`
- Digite a placa do veículo (formato brasileiro: ABC1234 ou ABC1D23)
- Digite o tipo do veículo: `carro`, `moto` ou `bicicleta`

### 2. Remover Veículo
- Selecione a opção `2`
- Digite a placa do veículo que deseja remover

### 3. Listar Veículos
- Selecione a opção `3`
- O sistema exibirá todos os veículos estacionados

### 4. Encerrar
- Selecione a opção `4` para sair do programa

## 🔍 Validação de Placas

O sistema aceita placas no formato brasileiro:
- **Formato antigo**: ABC1234 (3 letras + 4 números)
- **Formato Mercosul**: ABC1D23 (3 letras + 1 número + 1 letra + 2 números)

A validação é case-insensitive e remove automaticamente hífens e espaços.

## ⚡ Características Técnicas

- **Validação robusta**: Utiliza Regex compilado para melhor performance
- **Tratamento de duplicatas**: Não permite veículos com placas duplicadas
- **Interface limpa**: Console com menus intuitivos
- **Código organizado**: Arquitetura em camadas (Handlers, Services, Models, Utils)

## 🔧 Melhorias Futuras

- Persistência de dados (banco de dados ou arquivo)
- Cálculo de tempo de permanência e cobrança
- Interface gráfica (WPF/WinForms)
- API REST para integração
- Relatórios de ocupação

## 📝 Licença

Este projeto é de uso educacional e está disponível sob a licença MIT.

## 👥 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## 📞 Suporte

Em caso de dúvidas ou problemas, abra uma issue no repositório do projeto.
