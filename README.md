Acrividad: El propósito de esta aplicación es ayudar a una compañía ficticia llamada Chimi MiBarriga del Sr. Billy Navaja, para administrar sus procesos de venta de hamburguesas (chimichurri).
Nuestra aplicación ayudará al Sr. Billy a seleccionar los tipos de hamburguesas, ingredientes adicionales que se pueden agregar a la hamburguesa y el precio.
Queremos crear una hamburguesa clásica, pero también otros dos tipos de hamburguesas que son populares en el Chimi de Billy.

La hamburguesa clásica debería tener los siguientes ingredientes:
Tipo de Pan, carne y hasta un máximo de 4 ingredientes adicionales (tal como lechuga, tomates, bacon, pepinillo, etc) que el cliente pueda seleccionar para agregar a su hamburguesa. Cada uno de estos ingredientes llevan un cargo adicional en el precio, por tanto, usted necesita algún modo de contabilizar que tantos ingredientes se han agregado y calcular el precio (para la hamburguesa base y todos los ingredientes adicionales).
Esta hamburguesa tiene un precio base y los adicionales llevan un precio adicional por separado.

Crear una clase hamburguesa para manejar todo lo mencionado arriba.
El constructor debería solo incluir el tipo de pan, carne y precio. 
Además, crear dos variedades extras de hamburguesas (clases) para abastecer los consumidores

a) Hamburguesa Saludable (en tipo de pan integral, más dos ingredientes adicionales que se puedan agregar.
La hamburguesa saludable puede tener un total de 6 ingredientes adicionales en total.


Consejo: probablemente usted quiere procesar los dos ingredientes adicionales en esta nueva clase, no en la clase base, ya que los dos ingredientes adicionales son únicamente propios para esta nueva clase.
b) Hamburguesa Premium viene con papitas y bebidas como adicional, pero no se permiten ingredientes adicionales.
Consejo: Tiene que encontrar una manera de automáticamente agregar estos nuevos adicionales en el momento en el que el objeto de hamburguesa Premium es creada, y entonces prevenir que se agreguen otros ingredientes tras su creación.
Las tres clases deberían tener un método que pueda ser invocado en cualquier momento para mostrar el precio base de la hamburguesa más todos los adicionales, cada uno mostrando el nombre en detalle del ingrediente adicional agregado, el precio adicional por ingredientes, y el total de la venta para la hamburguesa seleccionada.
Para las dos clases adicionales se requiere que se agregue el precio sobre la clase base y entonces se vaya incrementando el precio total en la medida que se incorporen nuevos ingredientes a la hamburguesa.
Rseultado: ![image](https://github.com/user-attachments/assets/1b9626f3-d1e9-4d87-b7a7-3697c9bbcfa8)
