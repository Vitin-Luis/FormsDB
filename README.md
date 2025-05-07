# 📆 FormsDB

Sistema de agenda desenvolvido com **Windows Forms** em **C#**, utilizando um banco de dados para persistência de dados.

## 🛠️ Tecnologias Utilizadas

- **C#**
- **Windows Forms (.NET Framework)**

## 📋 Funcionalidades

- Cadastro de contatos
- Listagem de contatos no DataGridView
- Armazenamento dos dados no banco de dados
- Cada contato possui:
  - `id` (Identificador)
  - `nome`
  - `telefone`

## 🧱 Estrutura da Classe

A classe principal usada no agendamento é:

```C#
public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
}
```
