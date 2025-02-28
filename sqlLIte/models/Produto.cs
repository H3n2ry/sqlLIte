using SQLite;

namespace sqlLIte.models
{
    public class Produto
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public double Preco { get; set; }
    public string Descricao { get; set; }
    public double Quantidade { get; set; }
}
}
