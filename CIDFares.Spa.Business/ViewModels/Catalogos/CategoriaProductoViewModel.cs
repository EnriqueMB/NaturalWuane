﻿using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class CategoriaProductoViewModel
    {
        #region Propiedades privadas
        private ICategoriaProductoRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<CategoriaProducto> ListaCategoria { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CategoriaProductoViewModel(ICategoriaProductoRepository categoriaProductoRepository)
        {
            Repository = categoriaProductoRepository;
            ListaCategoria = new BindingList<CategoriaProducto>();
            GetAllAsync();
        }
        #endregion

        #region Metodos
        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaCategoria.Clear();
                foreach (var item in x)
                {
                    ListaCategoria.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

            #region Binding(Variables)
        private int _IdCategoriaProducto;

        public int IdCategoriaProducto
        {
            get { return _IdCategoriaProducto; }
            set
            {
                _IdCategoriaProducto = value;
                OnPropertyChanged(nameof(IdCategoriaProducto));
            }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }



        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        #endregion
    }
}
