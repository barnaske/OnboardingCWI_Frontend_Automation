#language: pt-br	
Funcionalidade: Verificar preços unitátarios

Cenário: Checando preço dos produtos
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username      | Password     |
		| standard_user | secret_sauce |
	E me autentico no sistema
	Então olho para o produto <produtos> e verifico que o valor está de acordo com <valores>
			
	Exemplos:
		| produtos                          | valores |
		| Sauce Labs Backpack               | $29.99  |
		| Sauce Labs Bike Light             | $9.99   |
		| Sauce Labs Bolt T-Shirt           | $15.99  |
		| Sauce Labs Fleece Jacket          | $49.99  |
		| Sauce Labs Onesie                 | $7.99   |
		| Test.allTheThings() T-Shirt (Red) | $15.99  |

