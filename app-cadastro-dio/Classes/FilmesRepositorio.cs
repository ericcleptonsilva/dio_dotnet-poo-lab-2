using app_cadastro_dio.Interfaces;
using System.Collections.Generic;
using System;

namespace app_cadastro_dio
{
    public class FilmesRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> listaFilme = new List<Filmes>();

        public void Atualiza(int id, Filmes objeto)
        {
            listaFilme[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filmes objeto)
        {
            listaFilme.Add(objeto);
        }

        public List<Filmes> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }

}