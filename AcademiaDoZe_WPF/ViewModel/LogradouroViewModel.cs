﻿using AcademiaDoZe_WPF.DataAcess;
using AcademiaDoZe_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace AcademiaDoZe_WPF.ViewModel
{
    public class LogradouroViewModel : ViewModelBase
    {
        // Objetos utilizados no Databinding
        // Recurso que permite a sincronização automática entre View e ViewModel,
        // através da propriedade DataContext da View.
        public ObservableCollection<Logradouro> Logradouros { get; set; }
        private Logradouro _selectedLogradouro;
        public RelayCommand FiltrarLogradouroCommand { get; set; }
        public Logradouro SelectedLogradouro
        {
            get { return _selectedLogradouro; }
            set
            {
                _selectedLogradouro = value;
                OnPropertyChanged("SelectedLogradouro");
                // libera somente se houver um logradouro selecionado
                LogradouroAtualizarCommand.RaiseCanExecuteChanged();
                LogradouroRemoverCommand.RaiseCanExecuteChanged();
                LogradouroAdicionarCommand.RaiseCanExecuteChanged();
            }
        }
        private LogradouroRepository _repository;

        public RelayCommand LogradouroAdicionarCommand { get; set; }
        public RelayCommand LogradouroAtualizarCommand { get; set; }
        public RelayCommand LogradouroRemoverCommand { get; set; }
        public LogradouroViewModel()
        {
            FiltrarLogradouroCommand = new RelayCommand(FiltrarLogradouro);
            Logradouros = new ObservableCollection<Logradouro>();
            _repository = new LogradouroRepository();
            // Inicializando os comandos
            LogradouroAdicionarCommand = new RelayCommand(AdicionarLogradouro, CanExecuteSubmit);
            LogradouroAtualizarCommand = new RelayCommand(AtualizarLogradouro, CanExecuteSubmit);
            LogradouroRemoverCommand = new RelayCommand(RemoverLogradouro, CanExecuteSubmit);
            GetAll();
        }

        private void FiltrarLogradouro(object parameter)
        {
            string cep = parameter as string;
            var logradouro = new Logradouro
            {
                Cep = cep
            };
            MessageBox.Show(logradouro.Cep);
            SelectedLogradouro = _repository.GetOne(logradouro);
        }

        private bool CanExecuteSubmit(object parameter)
        {
            // validação utilizada para liberar ou não os botões de atualizar e remover na view
            return SelectedLogradouro != null;
        }
        public void GetAll()
        {
            // busca no banco de dados e carrega em Logradouros
            Logradouros.Clear();
            _repository.GetAll().ForEach(data => Logradouros.Add(data));
        }

        private void AdicionarLogradouro(object obj)
        {
            if (SelectedLogradouro == null) return;
            if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    _repository.Add(SelectedLogradouro);
                    MessageBox.Show("Sucesso.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    GetAll();
                }
            }

        }

        private void AtualizarLogradouro(object obj)
        {
            if (SelectedLogradouro == null) return;
            if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    _repository.Update(SelectedLogradouro);

                    MessageBox.Show("Sucesso.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    GetAll();
                }
            }

        }
        private void RemoverLogradouro(object obj)
        {
            if (SelectedLogradouro == null) return;
            if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    _repository.Delete(SelectedLogradouro);

                    MessageBox.Show("Sucesso.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    GetAll();
                }
            }

        }
    }
}

