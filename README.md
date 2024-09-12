
# 🏗️ Open/Closed Principle (OCP)
![image](https://github.com/user-attachments/assets/a26b52d7-e978-484a-b79b-07684a57b2c5)
## O que é o OCP?

O **Princípio Aberto/Fechado (OCP)** afirma que uma classe deve ser **aberta para extensão** 🔄, mas **fechada para modificação** 🔒. Isso significa que podemos adicionar novas funcionalidades ao sistema sem precisar alterar o código existente. 🛡️ Isso ajuda a evitar bugs e mantém a estabilidade do sistema.

### 🚨 Problema comum:

Vamos supor que você tenha uma classe que calcula descontos para clientes. 🎟️ Se a cada novo tipo de cliente (Regular, VIP, Premium) você precisar alterar essa classe, estará violando o OCP, já que está sempre modificando o código existente. Isso pode introduzir novos bugs 🐞 ou gerar inconsistências no sistema.

### ✅ Solução com OCP:

A solução é permitir que o comportamento seja **extensível** sem modificar o código existente. Criamos uma estrutura em que novas funcionalidades podem ser adicionadas criando novas classes ou estratégias de desconto, sem mexer no código antigo. 🚀

### 🛠️ Explicação do Projeto:

No projeto implementando o OCP:
- Criamos a interface `IDiscountStrategy` 🎯 que define como os descontos são aplicados.
- Cada tipo de cliente tem sua própria estratégia de desconto: `RegularDiscountStrategy`, `VIPDiscountStrategy`, e `PremiumDiscountStrategy`. 🏷️
- A classe `DiscountService` 💼 usa a estratégia apropriada sem precisar ser modificada quando novos tipos de desconto são adicionados.

#### 🎯 Benefícios:
- **Extensibilidade**: Podemos adicionar novos tipos de descontos 💡 criando novas classes de estratégia, sem alterar o código que já funciona.
- **Menos bugs**: Como o código existente não precisa ser modificado 🔒, evitamos a introdução de novos bugs no sistema.
