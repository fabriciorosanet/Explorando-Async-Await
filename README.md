# Explorando-Async-Await

Este projeto é uma aplicação console simples que demonstra o uso de `async` e `await` em C#. Ele cria várias tarefas assíncronas e permite monitorar a execução de cada tarefa, exibindo mensagens no console durante a execução.

## Funcionalidades

- **Execução assíncrona:** O projeto cria três tarefas assíncronas que simulam operações demoradas.
- **Monitoramento da execução:** As mensagens no console permitem acompanhar o progresso de cada tarefa.
- **Uso de `Task.Delay`:** A simulação de atraso de 5segundos para cada tarefa mostra como o `await` funciona com operações de IO ou tarefas demoradas.

## Como Funciona

1. **Tarefas Assíncronas:** São criadas três tarefas simultâneas.
2. **Atraso Simulado:** Cada tarefa espera 5segundos antes de concluir, simulando uma operação de longa duração.
3. **Monitoramento no Console:** A aplicação exibe mensagens no console para indicar quando cada tarefa começa e quando é finalizada.
4. **Conclusão Sincronizada:** O programa só termina após todas as tarefas serem concluídas usando `Task.WhenAll()`.
