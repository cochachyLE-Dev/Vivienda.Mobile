<b>Vivienda</b> es una solución móvil completa para la gestión de inmuebles, desarrollada con Xamarin y .NET. Permite a los usuarios buscar propiedades por ubicación, tipo (departamentos, casas, oficinas), precio y características específicas (número de habitaciones, baños, estacionamiento, etc.). Además, ofrece herramientas para comparar propiedades, guardar favoritos y contactar directamente a los agentes inmobiliarios.

## Vivienda Views

| Categoría | Subcategoría | Pantalla | Descripción |
|---|---|---|---|
| Cuenta de usuario | Iniciar sesión | Views\UserAccount\SignInWithFacebookAccount.xaml | Iniciar sesión con cuenta de Facebook |
|  |  | Views\UserAccount\SignInWithGoogleAccount.xaml | Iniciar sesión con cuenta de Google |
|  |  | Views\UserAccount\SignIn.xaml | Iniciar sesión con DNI y contraseña |
|  | Crear cuenta | Views\UserAccount\CreateUserAccountVivienda.xaml | Crear cuenta usuario Vivienda |
|  |  | Views\UserAccount\CreateUserAccountAgent.xaml | Crear cuenta usuario Agente |
|  |  | Views\UserAccount\CreateUserAccountBroker.xaml | Crear cuenta usuario Broker |
|  | Validar y recuperar cuenta | Views\UserAccount\ValidateToken.xaml | Validar Token |
|  |  | Views\UserAccount\RecoverUserAccount.xaml | Recuperar cuenta |
| Dashboard | Ventas y alquileres | Views\Dashboards\SalesAndRentalsOnGoals.xaml | Ventas y alquileres sobre las metas ingresadas |
| Perfil de usuario | Mi perfil | Views\UserProfile\UserProfile\MyUserProfile.xaml | Mi perfil |
|  | Búsqueda de clientes | Views\UserProfile\UserProfile\ClientSearch.xaml | Búsqueda de clientes |
|  | Detalle de cliente | Views\UserProfile\UserProfile\ClientDetail.xaml | Detalle de cliente |
|  | Facturación | Views\UserProfile\Billing\SubscriptionPlansVivienda.xaml | Planes Vivienda (Oro, Plata, Bronce, Trial) |
|  |  | Views\UserProfile\Billing\ChangeSubscriptionPlans.xaml | Cambiar de plan Vivienda |
|  |  | Views\UserProfile\Billing\BillingInformation.xaml | Datos de facturación |
|  |  | Views\UserProfile\Billing\ProcessSubscriptionPayment.xaml | Procesar pago |
|  | Usuarios adicionales | Views\UserProfile\AdditionalUsers\RegisterRealEstateAgent.xaml | Registrar agente inmobiliario |
|  |  | Views\UserProfile\AdditionalUsers\ReadEstateAgentSearch.xaml | Búsqueda de agente inmobiliario |
|  |  | Views\UserProfile\AdditionalUsers/RealEstateAgentDetail.xaml | Detalle de agente inmobiliario |
|  |  | Views\UserProfile\AdditionalUsers\RateAndReviewRealEstateAgent.xaml | Calificar y comentar agente inmobiliario |
| Inmobiliaria | Especialista | Views\RealEstateProperty\Specialist\SpecialistProfile.xaml | Perfil de especialista |
|  | Búsqueda de inmueble | Views\RealEstateProperty\Search\RealEstateListingSearch.xaml | Búsqueda de inmueble |
|  |  | Views\RealEstateProperty\Search\RealEstateListingSearchByLocationMap.xaml | Búsqueda de inmueble por localización en mapa |
|  |  | Views\RealEstateProperty\Search\PropertyDetail.xaml | Detalle de inmueble y inmuebles similares |
|  | Programación de la visita | Views\RealEstateProperty\Visit\SchedulePropertyVisit.xaml | Programar la visita |
|  |  | Views\RealEstateProperty\Visit\RescheduleVisitProperty.xaml | Reprogramar la visita |
|  |  | Views\RealEstateProperty\Visit\ListScheduledPropertyVisits.xaml | Visitas programadas |
|  | Experiencia de la visita a inmueble | Views\RealEstateProperty\VisitExperience\RateAndCommentVisitedProperty.xaml | Calificar y comentar inmueble |
|  |  | Views\RealEstateProperty\VisitExperience\ViewCommentsRecentVisitsProperty.xaml | Comentarios de visitas recientes |
|  | Experiencia de usuario | Views\RealEstateProperty\UserExperience\RateAndCommentPlatformClient.xaml | Calificar y comentar Plataforma |
|  | Oferta del inmueble | Views\RealEstateProperty\Offer\ListPropertiesReserved.xaml | Inmuebles reservados |
|  |  | Views\RealEstateProperty\Offer\ListPropertiesRequested.xaml | Inmuebles solicitados |
|  |  | Views\RealEstateProperty.Offer\CancelPurchaseOffer.xaml | Cancelar oferta |
|  |  | Views\RealEstateProperty\Offer\DetailPropertyOffered.xaml | Detalle de inmueble |
|  | Documentos | Views\RealEstateProperty\Offer\ContractViewer.xaml | Visor contrato de compra |
| Preguntas y respuesta | Acerca de Vivienda | Views\Help\AboutTradingPlatform.xaml | Acerca de Vivienda |
|  | Preguntas Frecuentes | Views\Help\FrequentQuestions.xaml | Preguntas Frecuentes |
