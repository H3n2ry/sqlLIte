using SQLite;
using sqlLIte.models;

namespace sqlLIte.helpers
{
    public class SQliteDatabaseHelper
{
    readonly SQLiteAsyncConnection _conn;

    public SQliteDatabaseHelper(string caminho)
    {
        _conn = new SQLiteAsyncConnection(caminho);
        _conn.CreateTableAsync<Produto>().Wait();
    }

   
        public  Task <int> Insert(Produto p) 
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<Produto>> Update(Produto p) 
        { 
            string sql = "UPDATE Produto SET Descricao  = ?, Quantidade  = ?,  Preco = ? WHERE Id = ?";

            return _conn.QueryAsync<Produto>(
                sql, p.Descricao, p.Quantidade, p.Preco, p.Id
            );
        }

        public Task<int> Delete(int id)
        { 
          return  _conn.Table<Produto>().DeleteAsync(i => i.Id == id);
    }

        public Task<List<Produto>> getall() 
        { 
            return _conn.Table<Produto>().ToListAsync();
    }

        public Task<List<Produto>> search(string q) 
        {
                string sql = "SELECT  * Produto  WHERE  Descricao LIKE '%" + q + "%'";

                return _conn.QueryAsync<Produto>(sql);
        }



}
}
