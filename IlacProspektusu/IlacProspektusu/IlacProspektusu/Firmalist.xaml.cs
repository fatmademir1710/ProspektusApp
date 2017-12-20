using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IlacProspektusu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Firmalist : ContentPage
	{
        ApiManager apimngr;
        public Firmalist()
        {
            InitializeComponent();
            apimngr = ApiManager.DefaultManager;

            FillData();
        }

        async void FillData()
        {
            var result = await apimngr.getAllList();
            lstView.BindingContext = result;
        }
        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            
            DisplayAlert("Prospektüs",@"Farmakolojik özellikleri:
Parol Tabletin aktif maddesi parasetamol, klinik olarak kanıtlanmış, analjezik ve
antipiretik etkili bir ilaçtır.Hipotalamustaki termoregülasyon merkezi üzerindeki etkisi ile antipiretik etki gösterir.Parasetamol, prostaglandin sentezini önler.Gastrointestinal sistemden hızla absorbe olur.Parol, analjezik ve antipiretik etkilerini 15 - 30 dakikada ve 3 - 4 saat süreyle gösterir.Parasetamol, çoğu vücut dokularına hızlı ve düzenli olarak dağılır.Plazma yarı ömrü 1.25 - 3 saattir.Karaciğerde metabolize olur.Ağız yoluyla alınan parasetamol dozunun yaklaşık % 85'i 24 saat içinde idrarda serbest ve konjuge parasetamol olarak itrah edilir.
Endikasyonları:
Baş ve diş ağrıları, migren, dismenore, miyalji, nevralji, tüm müsküloskeletal ve
tonsilektomi ağrılarında analjezik; soğuk algınlığı, influenza ve diğer bakteriyel ve viral enfeksiyonlar da ise hem analjezik hem de antipiretik etki gösterir.
Kontrendikasyonları:
Parasetamole karşı aşırı duyarlılık ve karaciğer hastalıkları olan kişilerde kontrendikedir.
Uyarılar / Önlemler:
Anemili veya kardiyak, pulmoner, renal ya da hepatik hastalıkları olan kişilerde doktor kontrolü olmadan kullanılmamalıdır.Analjezik ilaçlar doktora danışılmadan uzun süre kullanılmamalıdır.Karaciğeri etkileyen diğer ilaçlar ile tedavi edilen hastalarda doktor önerisi ile kullanılmalıdır. 5 günden uzun süren ağrılarda, ateşi 39.5°C'den fazla olanlarda, 

3 günden daha uzun süren ateşte ve tekrarlayan ateş vakalarında doktor tavsiyesi olmadan kullanılmamalıdır.

Hamilelikte kullanım: Hamilelikte dikkatli ve doktor kontrolü altında fayda - zarar ilişkisi gözönünde bulundurularak kullanılmalıdır.

Emziren annelerde kullanım: Parasetamolün süte geçip geçmediği bilinmemektedir.Bu nedenle dikkatli kullanılmalıdır.
Yan etkiler/ Advers etkiler:
            Parasetamol nadiren alerjik ve aşırı duyarlılık reaksiyonlarına ve makülopapüler döküntülere neden olabilir. Yine çok nadir olarak mide bulantısı görülebilir.Bu yan etkiler ilaç kesildiğinde ortadan kalkar.Uzun süreli kullanımda nadir olarak hemolitik anemi, trombositopenik purpura ve agranülositoz vakaları kaydedilmiştir.
İlaç etkileşimleri:
Tedavi dozunda etkileşim belirlenememiştir. Yüksek dozda ve uzun süreli kullanımda antikoagülan ilaçların etkisini arttırmaktadır. Uzun süreli yüksek dozlarda kullanılan parasetamol, kumarin, indantoin türevleri ile fenotiazinlerle etkileşebilir, ürinez, 5 - hidroksi - indol asetik testinde yanlış pozitif sonuç verebilir.

Kullanım şekli ve dozu:
Doktor tarafından başka bir şekilde tavsiye edilmediği takdirde;

            12 yaşından büyük çocuklarda ve yetişkinlerde tavsiye edilen Parol Tablet dozajı, gerekli oldukça her 4 - 6 saatte bir 500 mg - 1 gr(1 - 2 tablet)'dır. Maksimum günlük doz 6 tablettir.

6 - 12 yaş arası çocuklarda ise gerekli oldukça her 4 - 6 saatte bir 250 mg - 500 mg(1 / 2 - 1 tablet)'dır. Maksimum günlük doz 4 tablettir. Çocuklarda 4 saatten daha sık aralarla ve 24 saatte toplam 4 dozdan daha fazla verilmemelidir. 

6 yaşından küçük çocuklarda kullanılmamalıdır. 

DOZ AŞIMI VE TEDAVİSİ:
İlacın toksik dozlarda alımından sonraki 2 - 3 saat içinde bulantı, kusma, karın ağrıları oluşur.Methemoglobin, deri mukoza, parmak tırnaklarında siyanoz, akut aşırı doz veya yüksek dozların uzun süreli kullanımı karaciğer hasarı(parasetamol aşırı dozunda doza bağlı bir komplikasyondur. 12 - 48 saat içinde karaciğer enzimleri yükselebilir ve protrombin zamanı uzayabilir.Ancak klinik semptomlar dozun alınmasından 1 - 6 gün sonrasına kadar görülmeyebilir.10 g'ın üzerinde alan yetişkinlerde toksisite görülmesi muhtemeldir.), SSS stimülasyonu, daha sonra depresyon, stupor, hipotermi, çabuk soluma, düzensiz hızlı ve zayıf nabız, düşük kan basıncı, dolaşım yetmezliği, koma, hepatik nekroz, sarılık, geçici azotemi, renal tübüler nekroz, hipoglisemi, metabolik asidoz, serebral ödem görülebilir. İlaç henüz alınmışsa, İpeka şurup ile kusturma veya gastrik aspirasyon ve lavaj yapılmalıdır. Antidot olarak 16 saat içinde asetil sistein verilmelidir. Aktif kömür ve toz katartikler, oral verilen asetil sisteinin absorpsiyonunu azaltabileceğinden bu maddelerin uygulanmasından kaçınılmalıdır. Hemodiyaliz, hemoperfüzyon yapılabilir. 

Peritoneal diyaliz etkisizdir.

", "Ok");
        }
    }
}