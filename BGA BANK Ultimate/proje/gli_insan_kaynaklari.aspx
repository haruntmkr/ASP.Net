<%@ Page Title="" Language="C#" MasterPageFile="~/Gli_IndexMasterPage.master" AutoEventWireup="true" CodeFile="gli_insan_kaynaklari.aspx.cs" Inherits="gli_insan_kaynaklari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <script type="text/javascript">
        function ActiveMenuSelection() {
            document.getElementById("liAnasayfa").removeAttribute(["class"]);
            document.getElementById("liBasvuru").removeAttribute(["class"]);
            document.getElementById("liBireysel").removeAttribute(["class"]);
            document.getElementById("liTicari").removeAttribute(["class"]);
            document.getElementById("liHakkimizda").setAttribute(["class"], ["active"]);
            document.getElementById("liIletisim").removeAttribute(["class"]);
        }
        window.onload = ActiveMenuSelection;
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
          <div class="span9" style="margin-right:30px"><!--Sol taraftaki panel***başlangıç-->
               <div class="well well-small">
                 <h4>İnsan Kaynakları</h4>
                  İnsan kaynakları işyerlerinde ihtiyaç duyulan insan gücünü karşılamak ve verimli kullanmak için oluşturulmuş bölümün adıdır.

Daha önceleri, personel bölümü olarak, devam takibi yani puantaj işlemi yaparak bordro hazırlayan bir görevi olan bu bölüm günümüzde faaliyet alanını genişleterek bu ismi almıştır.

En genel anlamıyla insan kaynakları, işveren ile çalışan veya potansiyel çalışanların ilişkilerini düzenleyen süreçlerin genel adı ve işletmelerde aynı adla anılan birimdir. İşgücü planlaması ile başlar, işe alım, ücretlendirme ve yan menfaatler, endüstriyel/sendikal ilişkiler, kurumsal performans yönetimi, kariyer yönetimi ve eğitim, çalışanların memnuniyetinin ölçümlenmesi, sosyal ve idari hizmetlerin tahsisi gibi çalışanları ilgilendiren tüm konuları kapsar. İnsan kaynakları çalışanları, yasa gereği, iş arayan bireylerden hiçbir maddi talepte bulunamazlar.

              </div>
          </div><!--Sol taraftaki panel***bitiş-->
        
    </div>
</asp:Content>

