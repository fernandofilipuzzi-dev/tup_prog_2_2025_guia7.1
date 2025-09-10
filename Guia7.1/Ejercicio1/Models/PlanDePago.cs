﻿
namespace Ejercicio1.Models;

public class PlanDePago : IComparable
{
    public Infractor Destinatario { get; private set; }

    public List<Cuota> cuotas = new List<Cuota>();

    private int cantidadCuotas;
    public int CantidadCuotas
    {
        get
        {
            return cantidadCuotas;
        }
    }

    public DateTime FechaAlta { get; private set; }

    public PlanDePago(double monto, int cantCuotas, DateTime fechaAlta, Infractor destinatario, Calendario calendario)
    {
        this.Destinatario = destinatario;
        this.cantidadCuotas = cantCuotas;
        this.FechaAlta = fechaAlta;

        if (cantidadCuotas == 0)
            throw new Exception("La cantidad de cuotras debe ser mayor a cero");

        double montoCuota = monto / cantCuotas;

        DateTime fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaAlta, calendario);

        int nroCuota = 1;
        while (nroCuota <= cantCuotas)
        {
            DateTime primerVenc = CalcularFechaVencimiento(fechaMesProximo, 8, calendario);
            DateTime segundoVenc = CalcularFechaVencimiento(primerVenc, 15, calendario);

            Cuota cuota = new Cuota(nroCuota, montoCuota, primerVenc,5,segundoVenc,20);

            cuotas.Add(cuota);

            fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaMesProximo, calendario);
            nroCuota++;
        }
    }

    private DateTime PrimerDiaHabilMesSiguiente(DateTime actual, Calendario feriados)
    {
        DateTime siguiente = new DateTime(actual.Year, actual.Month, 1).AddMonths(1);
        siguiente = DeterminarDiaHabil(siguiente, feriados);
        return siguiente;
    }

    private DateTime DeterminarDiaHabil(DateTime actual, Calendario feriados)
    {
        if (actual.DayOfWeek == DayOfWeek.Saturday || 
            actual.DayOfWeek == DayOfWeek.Sunday ||
            feriados[actual] != null)
        {
            actual = DeterminarDiaHabil(actual.AddDays(1), feriados);
        }
        return actual;
    }

    private DateTime CalcularFechaVencimiento(DateTime mesActual, int cantDiasHabiles, Calendario feriados)
    {
        DateTime venc = mesActual;

        int diasHabiles = 1;
        while (diasHabiles < cantDiasHabiles)
        {
            venc = DeterminarDiaHabil(venc.AddDays(1), feriados);
            diasHabiles++;
        }

        return venc;
    }

    public Cuota VerCuota(int idx)
    {
        Cuota cuota = null;

        if (idx >= 0 && idx < CantidadCuotas)
            cuota = cuotas[idx];

        return cuota;
    }

    public override string ToString()
    {
        return $"Plan de pagos: {Destinatario.ToString()}";
    }

    public string VerDetalle()
    {
        string linea = $"Destinatario: {Destinatario}\r\n" +
                        "\r\n";

        foreach (Cuota cuota in cuotas)
        {
            linea += cuota + "\r\n";
        }
        return linea;
    }

    public int CompareTo(object obj)
    {
        PlanDePago otro = obj as PlanDePago;
        if(otro !=null)
            return otro.Destinatario.DNI.CompareTo(otro.Destinatario.DNI);
        return 1;
    }

}
