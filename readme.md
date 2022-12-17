# Problema:

Se tienen 4 cajeros automáticos para servir una cola de clientes. Cada cajero tiene un tiempo de demora distinto. Se debe ingresar al programa un número que indique la posición en la fila de un cliente y se debe retornar la cantidad de minutos que dicho cliente debe esperar antes de tener acceso a un cajero.
 
Se asume que en el minuto Cero, los 4 cajeros están ocupados. En un minuto se libera el cajero A y en dos se libera el B. Los cajeros se identifican por su número ID (1-4), pero en la explicación los identifico por una letra para evitar confusiones.

## Detalle de los cajeros

| ID            | A | B | C | D |
|---------------|---|---|---|---|
| Número        | 1 | 2 | 3 | 4 |
| Tiempo Demora | 1 | 2 | 4 | 8 |


Se asume que las posiciones en la cola comienzan en Uno, como es normal para las personas. 

## Solucion básica:

Definir un algoritmo en base a posición en la fila, que dé como resultado el tiempo en minutos en que esa posición sale de la fila, es decir, obtiene acceso al recurso (cajero).


### Primero: 
Describimos una función que recibe el número de minuto actual (entero > 0) y retorna la cantidad de cajeros desocupados (0-4). De esa forma sabemos cuantos clientes salen de la cola en cada minuto.

 Se llamará int CajerosLibresEnMinuto(int minuto)

 Se auxilia de funciones para cada cajero:
 
#### Cajero A:
  Se demora Un minuto. Inicia ocupado en el minuto Cero, está ocupado un minuto, se desocupa en el 2. Está ocupado un minuto, se desocupa en el 4.
  Por inducción, está desocupado en los minutos pares y ocupado en los impares.

 lógica:
   `Si (minuto ES Par)
		Desocupado
	Else
		Ocupado`
		
#### Cajero B:
  Se demora Dos minutos. Inicia ocupado en el minuto Cero, está ocupado dos minutos, se desocupa en el 3. Está ocupado dos minutos, se desocupa en el 6.
  Por inducción, está desocupado en los minutos Múltiplos de 3.
  
  lógica:
   `Si (minuto ES Multiplo de 3)
		Desocupado
	Else
		Ocupado`
		
#### Cajero C:
  Se demora Cuatro minutos. Inicia ocupado en el minuto Cero, está ocupado 4 minutos, se desocupa en el 5. Está ocupado 4 minutos, se desocupa en el 10.
  Por inducción, está desocupado en los minutos Múltiplos de 5.
  
  lógica:
   `Si (minuto ES Multiplo de 5)
		Desocupado
	Else
		Ocupado`
		
#### Cajero D:
  Se demora Ocho minutos. Inicia ocupado en el minuto Cero, está ocupado 8 minutos, se desocupa en el 9. Está ocupado 8 minutos, se desocupa en el 19.
  Por inducción, esta desocupado en los minutos Múltiplos de 9.
  
  lógica:
  `Si (minuto ES Multiplo de 9)
		Desocupado
	Else
		Ocupado`

### Segundo:
 Se hace una iteración desde el valor 1 (minuto inicial), 
 para alimentar la función CajerosLibresEnMinuto();
 
  Al número que indica la posición en la fila del cliente se le resta la cantidad de cajeros libres en cada minuto, hasta que se haga cero. 
  Esto indica que el cliente salio de la fila hacia un cajero libre.

  La respuesta al problema es la cantidad de iteraciones realizadas, lo que equivale a la cantidad de minutos transcurridos mientras el cliente avanza desde su posición inicial en la fila hasta salir de ella.  
  
  **Ver código de clase SolucionBasica.**
 
## Solución mejorada: 

 Se introduce el requerimiento de retornar el cajero correspondiente al cliente, además del tiempo de espera.
 
 Se reutiliza todo lo posible de la solución anterior.
 
 Se modifica la función CajerosLibresEnMinuto para que retorne una lista con los números de los cajeros libres en cada minuto.
 
 Se modifica el método HallarSolucion para hacer una iteración en la lista y determinar el cajero correspondiente cuando la posición del cliente se hace cero.
 
 **Ver código de clase SolucionMejorada.**