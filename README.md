# BecomexTeste
Avalição Becomex Desenvolvimento WEB

##R.O.B.O.

**Descrição:** API para controle de um rôbo (Robô Operacional Bináriamente Orientado).

-------------------------------------------------------------------------------------

O estado inicial de todos movimentos é **"Em repouso"**. Os estados são representados na API pelos números que estão documentados entre parenteses ao lado dos seus respectivos nomes.

##Ações do robo

###Cabeça
+ Inclinar para baixo
+ Inclinar para cima
+ Rotação positiva
+ Rotação negativa

###Estados da cabeça
+ Inclinação
    * Para baixo (-1)
    * Em repouso (0)
	* Para cima (1)

###Estados de rotação da cabeça
+ Em repouso (0)
+ 45 graus (45)
+ 90 graus (90)
+ -45 graus (-45)
+ -90 graus (-90)

###Braço Direito
+ Cotovelo
    * Contrair
    * Descontrair
+ Pulso
    * Rotação positiva
    * Rotação negativa

###Braço Esquerdo
+ Cotovelo
    * Contrair
    * Descontrair
+ Pulso
    * Rotação positiva
    * Rotação negativa

###Estados do cotovelo
+ Em repouso (0)
+ Levemente contraído (1)
+ Contraído (2)
+ Fortemente contraído (4)

###Estados de rotação dos pulsos
+ Em repouso (0)
+ -45 graus (-45)
+ -90 graus (-90)
+ 45 graus (45)
+ 90 graus (90)
+ 135 graus (135)
+ 180 graus (180)
