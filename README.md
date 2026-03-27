# 🧮 Calculator App

Uma calculadora simples em C# que realiza operações matemáticas básicas, ideal para iniciantes aprenderem sobre tratamento de erros e métodos.

## 🎯 Funcionalidades

- ➕ **Adição** - Soma de dois números
- ➖ **Subtração** - Diferença entre números
- ✖️ **Multiplicação** - Produto de dois números
- ➗ **Divisão** - Quociente com validação contra divisão por zero

## 🚀 Como Usar

### Pré-requisitos
- .NET 8.0 ou superior

### Executar o Projeto

```bash
dotnet run
```

## 💡 Conceitos Aprendidos

- **Métodos** - Função `Calcular()` separada
- **Switch Expression** - Seleção de operação
- **Try-Catch** - Tratamento de exceções
- **Validação** - Prevenção de divisão por zero
- **Conversão de Dados** - `double.Parse()`
- **Strings Interpoladas** - Uso de `$""`
- **XMLDoc** - Documentação em XML

## 📚 Estrutura do Código

```
Program.cs
├── Main() - Ponto de entrada e loop principal
└── Calcular() - Método que realiza a operação
```

## 🎓 Ideal Para

- Aprender sobre métodos em C#
- Entender tratamento de exceções
- Praticar validação de entrada
- Aprender Switch Expression
- Segundo projeto em portfólio

## 📝 Exemplo de Uso

```
╔════════════════════════════════════╗
║        CALCULADORA SIMPLES         ║
╚════════════════════════════════════╝

Digite o primeiro número: 10

Operações disponíveis:
  + Adição
  - Subtração
  * Multiplicação
  / Divisão

Escolha a operação: +
Digite o segundo número: 5

────────────────────────────────────
Resultado: 10 + 5 = 15
────────────────────────────────────

Deseja fazer outro cálculo? (s/n): n
✓ Obrigado por usar a calculadora!
```

## 🔐 Tratamento de Erros

- ✓ Validação de números
- ✓ Proteção contra divisão por zero
- ✓ Operadores inválidos
- ✓ Mensagens de erro claras

## 🔄 Possíveis Melhorias

- Adicionar potenciação (^)
- Adicionar raiz quadrada (√)
- Histórico de cálculos
- Interface gráfica (WPF/WinForms)
- Cálculos em cadeia

---

**Autor:** Arthur Angelo De Jesus  
**Linguagem:** C#  
**Nível:** Iniciante ⭐
