namespace MvcModel2.Models
{
    public class HaberRepository
    {
        public List<Haber> HaberList()
        {
            // verinin çekileceği yer...
            List<Haber> returnList = new List<Haber>();
            returnList.Add(new Haber() { Baslik = "Haber 1", KisaAciklama = "Deneme Kısa Açıklama 1", Tarih = DateTime.Now });
            returnList.Add(new Haber() { Baslik = "Haber 2", KisaAciklama = "Deneme Kısa Açıklama 2", Tarih = DateTime.Now });
            returnList.Add(new Haber() { Baslik = "Haber 3", KisaAciklama = "Deneme Kısa Açıklama 3", Tarih = DateTime.Now });

            return returnList;
        }
    }
}
