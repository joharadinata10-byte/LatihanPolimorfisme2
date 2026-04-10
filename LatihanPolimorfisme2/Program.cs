BankTransfer bankTransfer = new BankTransfer();
EWallet eWallet = new EWallet();
KartuKredit kartuKredit = new KartuKredit();

Console.WriteLine("Simulasi Checkout");
Console.WriteLine("Pilih saldo");
Console.WriteLine("1. Bank Transfer \n2. E-Wallet \n3. Kartu Kredit");
Console.Write("Pilihan anda (1/2/3): ");
string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        BankTransfer banktransfer = new BankTransfer();
        bankTransfer.Bayar(10000);
        break;
    case "2":
        EWallet ewallet = new EWallet();
        eWallet.Bayar(10000);
        break;
    case "3":
        KartuKredit kartukredit = new KartuKredit();
        kartuKredit.Bayar(10000);
        break;
    default:
        Console.WriteLine("Pilhan Invalid");
        break;
}

class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine($"Segera melakukan pembayaran sebesar Rp{jumlah}");
    }
}
class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silakan transfer sejumlah Rp{jumlah} ke nomor rekening 123456");
    }
}
class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah Rp{jumlah}");
    }
}
class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sebesar Rp{jumlah} berhasil dilakukan");
    }
}