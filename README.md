# 🏦 Projeto BBank - C# Console Application

Este projeto é uma aplicação de console em C# que simula um sistema bancário com diferentes tipos de contas e funcionalidades de operações financeiras.

## 🚀 Funcionalidades

### Criar Contas 📇

- Contas disponíveis: `ContaCorrente`, `ContaPoupança`, `ContaInvestimento`.
- Cada conta é identificada por `Titular`, `Número` e `Saldo`.
- O número da conta é gerado automaticamente.

### Operações Bancárias 💰

- **Depositar**: Adicione fundos à conta.
- **Sacar**: Retire fundos da conta (com validações de saldo).
  - Saque em `ContaPoupança` subtrai uma taxa de R$ 0,10.
- **Transferir**: Transfira fundos entre contas.

### Validações 🔍

- Saldo suficiente é checado antes de permitir saques ou transferências.
- Contas não podem ter saldo negativo.

### Relatórios Internos 📝

- **TotalizadorDeContas**: Calcula e exibe o saldo total de todas as contas.
- **TotalizadorDeTributos**: Calcula o total de tributos acumulados de `ContaInvestimento` e `SeguroDeVida`.

### Listagem de Contas 📑

- Listar todas as contas.
- Listar contas com saldo maior que R$ 1000.
