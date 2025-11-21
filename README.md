# 🏴‍☠️ Caça ao Tesouro

<div align="center">

![Versão Beta 1](./image.png)

**Um jogo de estratégia e sorte onde tens de encontrar o tesouro escondido!**

![Versão Final](./imgFinal.png)

</div>

---

## 📋 Índice

- [Sobre o Projeto](#-sobre-o-projeto)
- [Características](#-características)
- [Como Jogar](#-como-jogar)
- [Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [Estrutura do Projeto](#-estrutura-do-projeto)
- [Instalação e Execução](#-instalação-e-execução)
- [Funcionalidades Técnicas](#-funcionalidades-técnicas)
- [Capturas de Ecrã](#-capturas-de-ecrã)

---

## 🎯 Sobre o Projeto

**Caça ao Tesouro** é um jogo desenvolvido em C# utilizando Windows Forms, onde o objetivo é encontrar um tesouro escondido numa grelha de 16 posições (4x4). O jogo desafia os jogadores a utilizarem estratégia e lógica, oferecendo dicas sobre a proximidade do tesouro após cada tentativa.

O projeto foi desenvolvido como parte de um trabalho académico, demonstrando conceitos de programação orientada a objectos, encapsulamento e gestão de estado de jogo.

---

## ✨ Características

- 🎮 **Interface intuitiva** com grelha de 16 botões
- 🔍 **Sistema de dicas** baseado na distância do tesouro
- ⏱️ **Limite de tentativas** (4 tentativas por jogo)
- 🔄 **Sistema de reinício** para jogar múltiplas vezes
- 💀 **Feedback visual** com emojis e mensagens
- 🎉 **Animações e mensagens** de vitória/derrota

---

## 🎲 Como Jogar

1. **Iniciar o Jogo**: Ao abrir a aplicação, um tesouro é automaticamente escondido numa das 16 posições.

2. **Fazer Tentativas**: Clica num dos botões da grelha para procurar o tesouro.

3. **Receber Dicas**: Após cada clique, receberás uma dica indicando a distância do tesouro:
   - 🔥 **"Está MUITO perto! Ao lado!"** - O tesouro está adjacente (distância 1)
   - **"Está perto!"** - O tesouro está a 2 casas de distância
   - **"Tens uma pista quente..."** - O tesouro está a 3-4 casas de distância
   - **"Está bem longe!"** - O tesouro está a mais de 4 casas de distância

4. **Ganhar ou Perder**:
   - ✅ **Vitória**: Encontra o tesouro antes de esgotares as 4 tentativas
   - ❌ **Derrota**: Se esgotares as 4 tentativas sem encontrar o tesouro

5. **Reiniciar**: Utiliza o botão de reset para iniciar um novo jogo a qualquer momento.

---

## 🛠️ Tecnologias Utilizadas

- **C#** - Linguagem de programação
- **.NET Framework** - Framework de desenvolvimento
- **Windows Forms** - Interface gráfica de utilizador
- **Visual Studio** - Ambiente de desenvolvimento integrado

---

## 📁 Estrutura do Projeto

```
Projeto Caça ao Tesouro/
│
├── Projeto Caça ao tesouro/
│   ├── Form1.cs              # Interface principal e lógica de interação
│   ├── Form1.Designer.cs     # Design da interface gráfica
│   ├── GameManager.cs        # Lógica do jogo e gestão de estado
│   ├── Program.cs            # Ponto de entrada da aplicação
│   └── Properties/           # Configurações e recursos
│
├── image.png                 # Captura de ecrã da versão Beta 1
├── imgFinal.png              # Captura de ecrã da versão final
├── gambling.png              # Imagem adicional do projeto
└── README.md                 # Esta documentação
```

### Componentes Principais

#### `Form1.cs`
- Gerencia a interface do utilizador
- Processa os cliques nos botões
- Exibe mensagens e feedback ao jogador
- Controla a visibilidade dos elementos visuais

#### `GameManager.cs`
- Gera posições aleatórias para o tesouro
- Calcula distâncias e gera dicas
- Controla o número de tentativas
- Implementa a lógica principal do jogo

---

## 🚀 Instalação e Execução

### Pré-requisitos

- Windows 7 ou superior
- .NET Framework (versão compatível com o projeto)
- Visual Studio (opcional, para edição do código)

### Executar a Aplicação

1. **Método 1 - Executável Directo**:
   - Navega até à pasta raiz do projeto
   - Executa o ficheiro `Caça-ao-Tesouro-Beta1.exe`

2. **Método 2 - Visual Studio**:
   - Abre o ficheiro `Projeto Caça ao tesouro.sln` no Visual Studio
   - Pressiona `F5` ou clica em "Iniciar" para compilar e executar

3. **Método 3 - Compilação Manual**:
   - Abre o terminal na pasta do projeto
   - Compila utilizando o compilador C# do .NET Framework

---

## 🔧 Funcionalidades Técnicas

### Sistema de Dicas

O jogo utiliza um algoritmo de distância de Manhattan para calcular a proximidade do tesouro:

```csharp
// Cálculo da distância entre a posição clicada e o tesouro
int distancia = Math.Abs(linhaClicada - linhaTesouro) + 
                Math.Abs(colunaClicada - colunaTesouro);
```

### Encapsulamento

O projeto demonstra boas práticas de programação orientada a objectos:

- Propriedades com `get` e `set` para controlo de acesso
- Separação de responsabilidades entre `Form1` (UI) e `GameManager` (lógica)
- Constantes para valores fixos (ex: `MAX_TENTATIVAS`)

### Gestão de Estado

- Controlo de tentativas restantes
- Desactivação de botões após clique
- Reinicialização completa do estado do jogo

---

## 📸 Capturas de Ecrã

### Versão Beta 1

![Versão Beta 1](./image.png)

*Interface inicial do jogo na versão beta, mostrando a grelha de 16 botões e os controlos básicos.*

### Versão Final

![Versão Final](./imgFinal.png)

*Interface final do jogo com todas as funcionalidades implementadas, incluindo feedback visual e sistema de dicas.*

---

## 📝 Notas de Desenvolvimento

- O tesouro é gerado aleatoriamente em cada novo jogo
- O sistema de dicas baseia-se na distância de Manhattan (soma das diferenças de linha e coluna)
- O jogo suporta múltiplas partidas sem necessidade de reiniciar a aplicação
- Todas as mensagens são exibidas em português

---

## 👨‍💻 Desenvolvimento

Este projeto foi desenvolvido como parte de um trabalho académico, focando-se em:

- Programação orientada a objectos
- Encapsulamento e abstração
- Gestão de estado de aplicação
- Interface gráfica de utilizador
- Algoritmos de cálculo de distância

---

## 📄 Licença

Este projeto foi desenvolvido para fins educacionais.

---

<div align="center">

**Boa sorte na tua caça ao tesouro! 🏴‍☠️💎**

Desenvolvido por Ricardo Kassoma nº22 e Pedro Daniel nº20 em C# no Curso de Gestão e Porgramação de Sistemas Informáticos na Alcaides Faria, Barcelos, Portugal

</div>
