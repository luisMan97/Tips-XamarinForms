# Tips-XamarinForms

## Installation
Run git clone to download proyect

```ruby
git clone https://github.com/luisMan97/Tips-XamarinForms.git
```

#### Funcionalidades
- La pantalla principal cuenta con un listado de tips que se pueden agregar y guardar.
- La pantalla principal cuenta con un botón que permite ir a la pantalla de agregar un nuevo Tip.
- Cuando se selecciona un Tip se va al detalle del Tip.
- Cada post de los favoritos tiene el gesto nativo de deslizar y eliminar para iOS y de mantener oprimido y eliminar para Android.
- En la pantalla del detalle del Post se visualiza el titulo y la descripción del Tip.
- En la pantalla del detalle del Post se tiene un botón para ir a editar el Tip.

- Se muestra mensaje de error cuando falla el guardado del Tip.

#### Funcionalidades técnicas:
- La aplicación está desarrollada en Xamarin Forms.
- La aplicación tiene MVVM cómo patrón de diseño arquitectónico.
- La aplicación hace uso de inyección de dependencias para pasar la información al detalle del Tip y a la vista de editar un Tip.

#### Arquitectura
Se implementó MVVM como arquitectura, con las siguientes capas:
1) View: Contiene las Vistas
2) ViewModel: Contiene los casos de uso (acciones de la aplicación y lógica de negocios)
4) Model: Contiene las entidades
5) Data: Contiene capa de persistencia de datos para poder gestionar la base de datos local.
