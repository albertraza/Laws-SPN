public class pBaseVentaFacturacion
{
    public string ID { get; set; }
    public string vendedorID { get; set; }
    public string compradorID { get; set; }
    public string Descripcion { get; set; }
    public string MontoVenta { get; set; }
    public string Honorarios { get; set; }
    public string Abono { get; set; }
    public string servicioID { get; set; }

    public pBaseVentaFacturacion(){ }
    public pBaseVentaFacturacion(string id, string ven, string com, string des, string monto, string honom, string abono, string serv)
    {
        ID = id;
        vendedorID = ven;
        compradorID = com;
        Descripcion = des;
        MontoVenta = monto;
        Honorarios = honom;
        Abono = abono;
        servicioID = serv;
    }
}

public class pBaseDivorcioAccidenteFacturacion
{
    public string ID { get; set; }
    public string serviceID { get; set; }
    public string DemandanteID { get; set; }
    public string DemandadoID { get; set; }
    public string Pagos { get; set; }
    public string Honorarios { get; set; }
    public string Abono { get; set; }

    public pBaseDivorcioAccidenteFacturacion() { }
    public pBaseDivorcioAccidenteFacturacion(string id, string servi, string deman, string demano, string pagos, string hono, string abono)
    {
        ID = id;
        serviceID = servi;
        DemandanteID = deman;
        DemandadoID = demano;
        Pagos = pagos;
        Honorarios = hono;
        Abono = abono;
    }
}

public class pBaseAlquilerFacturacion
{
    public string ID { get; set; }
    public string ClienteID { get; set; }
    public string InquilinoID { get; set; }
    public string GaranteID { get; set; }
    public string servicioID { get; set; }
    public string Mensualidad { get; set; }
    public string Honorarios { get; set; }
    public string Detalles { get; set; }
    public string Direccion { get; set; }
    public string City { get; set; }
    public string Deposito { get; set; }
    public string Abono { get; set; }
    public string Alquiler { get; set; }
    public string ContratoTotal { get; set; }

    public pBaseAlquilerFacturacion() { }
    public pBaseAlquilerFacturacion(string id, string cliente, string inquilino, string garante, string servicio, string mensua,
        string honorarios, string detalles, string direccion, string city, string deposito, string abono, string alquiler, string contrato)
    {
        ID = id;
        ClienteID = cliente;
        InquilinoID = inquilino;
        GaranteID = garante;
        servicioID = servicio;
        Mensualidad = mensua;
        Honorarios = honorarios;
        Detalles = detalles;
        Direccion = direccion;
        City = city;
        Deposito = deposito;
        Abono = abono;
        Alquiler = alquiler;
        ContratoTotal = contrato;
    }
}

public class pBaseClientes
{
    public string ID { get; set; }
    public string Nombre { get; set; }
    public string apellido { get; set; }
    public string Idcard { get; set; }
    public string StatusID { get; set; }
    public string picture { get; set; }
    public string registerDate { get; set; }
    public string cAddress { get; set; }
    public string Ocupation { get; set; }
    public string CityID { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string cellphone { get; set; }
    public string pasaporte { get; set; }

    public pBaseClientes() { }
    public pBaseClientes(string id, string nom, string ape, string idcard, string sta, string pic, string regis, string add,
        string ocupa, string city, string ema, string ocu, string pho, string cell, string pasa)
    {
        ID = id;
        Nombre = nom;
        apellido = ape;
        Idcard = idcard;
        StatusID = sta;
        picture = pic;
        registerDate = regis;
        cAddress = add;
        Ocupation = ocupa;
        CityID = city;
        email = ema;
        phone = pho;
        cellphone = cell;
        pasaporte = pasa;
    }
}