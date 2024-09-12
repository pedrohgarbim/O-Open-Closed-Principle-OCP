// Sem o uso do segundo principio 

using SOLID2OCP.NO_OCP;
using SOLID2OCP.WITH_ACP.Discounts;
using SOLID2OCP.WITH_ACP;

var productWrong = new ProductNoOCP { Name = "Laptop", Price = 1000 };
var discountService = new DiscountServiceNoOCP();

Console.WriteLine("Desconto Regular: " + discountService.GetDiscount(productWrong, "Regular"));
Console.WriteLine("Desconto VIP: " + discountService.GetDiscount(productWrong, "VIP"));
Console.WriteLine("Desconto Premium: " + discountService.GetDiscount(productWrong, "Premium"));

// Motivo de ir contra o princício OCP é que toda vez que um novo
// tipo de cliente for adicionado, ira ter que mudar a classe 
// para desconto, violando o princípio OCP



Console.WriteLine("Forma Correta");



// Com o uso do segundo principio

var productRight = new Product { Name = "Laptop", Price = 9500 };

// Cliente Regular
var discountServiceRegular = new DiscountService(new RegularDiscountStrategy());
Console.WriteLine("Desconto Regular: " + discountServiceRegular.GetDiscount(productRight));

// Cliente VIP
var discountServiceVIP = new DiscountService(new VIPDiscountStrategy());
Console.WriteLine("Desconto VIP: " + discountServiceVIP.GetDiscount(productRight));

// Cliente Premium
var discountServicePremium = new DiscountService(new PremiumDiscountStrategy());
Console.WriteLine("Desconto Premium: " + discountServicePremium.GetDiscount(productRight));

//  a classe interface DiscountService está fechada para modificações e aberta para extensões,
//  seguindo o princípio OCP. Agora, novos tipos de descontos podem ser adicionados
//  sem alterar a lógica existente.
