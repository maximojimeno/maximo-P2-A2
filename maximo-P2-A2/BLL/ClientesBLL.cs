using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using maximo_P2_A2.Data;
using maximo_P2_A2.Entities;
using Microsoft.EntityFrameworkCore;

namespace maximo_P2_A2.BLL
{
    public class ClientesBLL
    {
        public async static Task<bool> Guardar(Clientes cliente) {
            if (!await Existe(cliente.ClienteId))
                return await Insertar(cliente);
            else
                return await Modificar(cliente);
        }

        public async static Task<bool> Insertar(Clientes cliente) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Clientes.Add(cliente);
                paso = await contexto.SaveChangesAsync() > 0;
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<bool> Modificar(Clientes cliente) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Entry(cliente).State = EntityState.Modified;

                paso = await contexto.SaveChangesAsync() > 0;

            } catch (Exception) {

                throw;
            } finally {
                await contexto.DisposeAsync();
            }
            return paso;
        }

        public async static Task<bool> Eliminar(int id) {
            bool paso = false;
            Contexto contexto = new Contexto();
            try {
                var cliente = contexto.Clientes.Find(id);

                if (cliente != null) {
                    contexto.Clientes.Remove(cliente);
                    paso = await contexto.SaveChangesAsync() > 0;
                }
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<Clientes> Buscar(int id) {
            Contexto contexto = new Contexto();
            Clientes cliente;

            try {
                cliente = await contexto.Clientes
                    .Where(v => v.ClienteId == id)
                    .FirstOrDefaultAsync();
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return cliente;
        }


        public async static Task<bool> Existe(int id) {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try {
                encontrado = await contexto.Clientes.AnyAsync(v => v.ClienteId == id);
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return encontrado;
        }

        public async static Task<List<Clientes>> GetClientes(int clienteId = 0) {
            Contexto contexto = new Contexto();

            List<Clientes> clientes = new List<Clientes>();
            await Task.Delay(01); 

            try {

                clientes = await contexto.Clientes.ToListAsync();

            } catch (Exception) {

                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return clientes;

        }

    }
}