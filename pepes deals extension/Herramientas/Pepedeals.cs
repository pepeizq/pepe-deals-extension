
#nullable disable

using System.Text.Json.Serialization;

namespace Herramientas
{
	public class Json
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("nombre")]
		public string Nombre { get; set; }

		[JsonPropertyName("minimosHistoricos")]
		public List<JsonPrecio> Historicos { get; set; }

		[JsonPropertyName("preciosActuales")]
		public List<JsonPrecio> Actuales { get; set; }

		[JsonPropertyName("bundles")]
		public List<JsonBundle3> Bundles { get; set; }

		[JsonPropertyName("bundlesPasados")]
		public int BundlesPasados { get; set; }

		[JsonPropertyName("gratis")]
		public List<JsonGratis> Gratis { get; set; }

		[JsonPropertyName("suscripciones")]
		public List<JsonSuscripcion> Suscripciones { get; set; }

		[JsonPropertyName("idSteam")]
		public int IdSteam { get; set; }

		[JsonPropertyName("idGOG")]
		public int IdGog { get; set; }

		[JsonPropertyName("slugGOG")]
		public string SlugGog { get; set; }

		[JsonPropertyName("slugEpic")]
		public string SlugEpic { get; set; }

	}

	public class JsonPrecio
	{
		[JsonPropertyName("datos")]
		public JsonPrecio2 Datos { get; set; }

		[JsonPropertyName("tienda")]
		public string Tienda { get; set; }

		[JsonPropertyName("tiendaIcono")]
		public string TiendaIcono { get; set; }
	}

	public class JsonPrecio2
	{
		[JsonPropertyName("descuento")]
		public int Descuento { get; set; }

		[JsonPropertyName("precio")]
		public decimal Precio { get; set; }

		[JsonPropertyName("precioCambiado")]
		public decimal PrecioCambiado { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("moneda")]
		public int Moneda { get; set; }

		[JsonPropertyName("tienda")]
		public string Tienda { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }

		[JsonPropertyName("fechaDetectado")]
		public DateTime FechaDetectado { get; set; }

		[JsonPropertyName("fechaActualizacion")]
		public DateTime FechaActualizacion { get; set; }

		[JsonPropertyName("codigoDescuento")]
		public int CodigoDescuento { get; set; }

		[JsonPropertyName("codigoTexto")]
		public string CodigoTexto { get; set; }
	}

	public class JsonBundle3
	{
		[JsonPropertyName("tienda")]
		public int Tienda { get; set; }

		[JsonPropertyName("nombre")]
		public int Nombre { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }
	}

	public class JsonGratis
	{
		[JsonPropertyName("datos")]
		public JsonGratis2 Datos { get; set; }

		[JsonPropertyName("nombreGratis")]
		public string NombreGratis { get; set; }

		[JsonPropertyName("iconoGratis")]
		public string IconoGratis { get; set; }
	}

	public class JsonGratis2
	{
		[JsonPropertyName("tipo")]
		public int Tipo { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("fechaEmpieza")]
		public DateTime FechaEmpieza { get; set; }

		[JsonPropertyName("fechaTermina")]
		public DateTime FechaTermina { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }
	}

	public class JsonSuscripcion
	{
		[JsonPropertyName("datos")]
		public JsonSuscripcion2 Datos { get; set; }

		[JsonPropertyName("nombreSuscripcion")]
		public string NombreSuscripcion { get; set; }

		[JsonPropertyName("iconoSuscripcion")]
		public string IconoSuscripcion { get; set; }
	}

	public class JsonSuscripcion2
	{
		[JsonPropertyName("tipo")]
		public int Tipo { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("fechaEmpieza")]
		public DateTime FechaEmpieza { get; set; }

		[JsonPropertyName("fechaTermina")]
		public DateTime FechaTermina { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }
	}
}
