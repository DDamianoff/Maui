using Ma.Backend.Models.DataBase;
using Maui.Backend.Models.DataBase;

/// <summary>
/// Esta clase es una éxpresión compresible
/// para un ComboBox de lo que es un "Worker".
/// </summary>
public class WorkerItem
{
    /// <summary>
    /// Almacena al trabajador actual.
    /// </summary>
    public Worker ThisWorker { get; }
    public string FullName { get; }
    public WorkerItem(Worker worker)
    {
        this.ThisWorker = worker;
        FullName = $"{worker.FirstName} {worker.LastName}";
    }

    /// <summary>
    /// el ComboBox se vale de éste método
    /// para expresar los objetos que contiene
    /// como Elementos seleccionables y visibles.
    /// </summary>
    /// <returns>
    /// Nombre completo (string) del Trabajador
    /// que contiene el objeto.
    /// </returns>
    public override string ToString()
    {
        return FullName;
    }
}