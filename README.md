# Editor de Texto com Dicionário - Trabalho de Faculdade

Este projeto consiste em um editor de texto desenvolvido em C# utilizando a biblioteca Windows Forms. Foi criado como parte de um trabalho acadêmico, com o objetivo principal de estudar e aplicar conceitos de estrutura de dados, como listas encadeadas e nós.

## Funcionalidades

1. **Editor de Texto**: O programa permite que o usuário digite, edite e salve textos de forma intuitiva e fácil de usar. Ele oferece recursos como digitação, exclusão, formatação básica (como negrito, itálico e sublinhado) e salvamento de arquivos.

2. **Dicionário de Palavras**: O editor de texto inclui um dicionário de palavras que o usuário pode acessar e gerenciar. É possível adicionar novas palavras ao dicionário e, em seguida, o programa será capaz de reconhecer essas palavras no texto digitado.

## Estrutura de Dados Utilizada

Para implementar o dicionário e o reconhecimento de palavras, foram utilizadas listas encadeadas e nós. Essa escolha se baseia na eficiência da estrutura de dados para operações de inserção e busca, o que é essencial para o objetivo do projeto.

Cada nó da lista encadeada armazena uma palavra do dicionário. O nó possui dois componentes principais: o valor (a palavra em si) e uma referência para o próximo nó na lista. A cada inserção de uma nova palavra no dicionário, um novo nó é criado e adicionado à lista encadeada.

Durante a verificação do texto digitado, o programa percorre a lista encadeada, comparando cada palavra com as palavras no texto. Quando há uma correspondência, a palavra é destacada ou uma ação específica pode ser realizada.

## Próximos Passos

Este projeto serve como uma base sólida para o estudo de estruturas de dados e a implementação de recursos em um editor de texto. Para melhorar ainda mais o programa, algumas melhorias podem ser consideradas:

- Implementar um recurso de correção ortográfica utilizando o dicionário de palavras.
- Permitir a importação e exportação de documentos em diferentes formatos.

## Conclusão

O desenvolvimento deste editor de texto com dicionário foi um desafio interessante e enriquecedor, que proporcionou a oportunidade de aprofundar o conhecimento em estruturas de dados e sua aplicação prática. O projeto oferece uma base sólida para expansão e melhoria, possibilitando um maior aprendizado e desenvolvimento de habilidades na área de programação.
