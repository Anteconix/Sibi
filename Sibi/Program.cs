using Sibi;

Tela tela = new Tela();
BancoDados bancoDados = new BancoDados();
HospedeCRUD reserva = new HospedeCRUD(bancoDados, tela);
HotelCRUD reserva = new HotelCRUD(bancoDados, tela);
PagamentoCRUD reserva = new PagamentoCRUD(bancoDados, tela);
QuartoCRUD reserva = new QuartoCRUD(bancoDados, tela);
RedeHoteisCRUD reserva = new RedeHoteisCRUD(bancoDados, tela);
ReservaCRUD reserva = new ReservaCRUD(bancoDados, tela);
ServicoExtraCRUD reserva = new ServicoExtraCRUD(bancoDados, tela);


List<string> menu = new List<string>();
menu.Add("1 - Cadastro de Reservas");
menu.Add("2 - Controle de Hospede  ");
menu.Add("3 - Controle de Quartos   ");
menu.Add("4 - Anotações");
menu.Add("0 - Sair");

string op;

while (true)
{
    tela.montarTelaSistema("Sistemas de Anotações");
    op = tela.mostrarMenu(menu, 3, 3);

    if (op == "0") break;
    if (op == "1") reserva.executarCRUD();
    if (op == "2") hotel.executarCRUD();
    if (op == "3") quartos.executarCRUD();
    //if (op == "4") anotacaoCRUD();
}