namespace EditorDeTexto
{
    internal static class Program
    {
        private static readonly string diretorio = @"C:\Temp\";
        private static readonly string dadosDicionario = @"perseverança,condolências,ninfomaníaca,remanescente,prerrogativa,extrovertido,complacência,procrastinar,discrepância,independente,determinação,consequência,intermitente,conveniência,benevolência,eclesiástico,contingência,compartilhar,felicitações,transgressão,consideração,nãoobstante,convergência,cordialidade,concomitante,disseminação,subsistência,conhecimento,convencional,cumplicidade,sistematizar,proselitismo,complexidade,prescindível,controvérsia,imprevisível,impertinente,inverossímil,displicência,interlocutor,coincidência,libertinagem,extemporâneo,maledicência,intolerância,proporcionar,conformidade,resplandecer,escatológico,intempestivo,fraternidade,estabilidade,misericórdia,perseverante,mediocridade,persistência,coexistência,circunspecto,preeminência,parcialmente,protagonista,consolidação,introvertido,maquiavélico,complementar,hermenêutica,aquiescência,proeminência,destinatário,estigmatizar,ninfomaníaco,deslumbrante,constituição,caracterizar,oportunidade,escarnecedor,consistência,parcialidade,interessante,superestimar,entendimento,incircunciso,enclausurado,procedimento,condicionado,generosidade,fragmentação,circuncidado,literalmente,legitimidade,depreciativo,proficiência,desenvoltura,ininterrupto,incolumidade,racionalizar,simplicidade,sobremaneira,constrangido,beneficência,reciprocidade,contemporâneo,inconveniente,circunstância,discernimento,solidariedade,promiscuidade,heterossexual,intransigente,credibilidade,aprovisionado,transcendente,discriminação,assintomático,epistemologia,contrapartida,ressignificar,comprobatório,perpendicular,ressentimento,estereotipado,incongruência,reminiscência,recenseamento,possibilidade,intermediário,indispensável,preponderante,veementemente,subjetividade,singularidade,longanimidade,hodiernamente,pormenorizado,subserviência,convalescença,autenticidade,incontinência,transformação,instabilidade,superveniente,reivindicação,sensibilidade,independência,elegibilidade,latifundiário,superestimado,multifacetado,indissociável,contraditório,introspectivo,recalcitrante,eventualmente,incredulidade,desmistificar,inconsequente,sobressalente,ininteligível,quintessência,inescrupuloso,integralmente,indescritível,filhopródigo,comportamento,adespeitode,homogeneidade,personalidade,magnificência,implementação,provavelmente,precipuamente,peculiaridade,circunscrição,remanejamento,convalescente,consentimento,consciencioso,monossilábico,arrefecimento,contentamento,correlacionar,incondicional,serendipidade,incandescente,predisposição,versatilidade,conscientizar,indeterminado,desnecessário,irresponsável,especificação,supersticioso,imperceptível,ressarcimento,reconciliação,tergiversação,representação,receptividade,identificação,incognoscível,imprescindível,condescendente,característica,idiossincrasia,concupiscência,extraordinário,demasiadamente,sadomasoquismo,intercorrência,irrepreensível,consubstanciar,incomensurável,preponderância,arbitrariedade,pronta-entrega,discricionário,especificidade,posteriormente,imprescritível,intransponível,contextualizar,empreendimento,entretenimento,ancestralidade,revolucionário,infraestrutura,paulatinamente,superveniência,transcendental,atenciosamente,relacionamento,bem-aventurado,periodicamente,arrependimento,transcendência,imparcialidade,pontodevista,democratização,reconhecimento,diligentemente,insignificante,personificação,inconsistência,espontaneidade,despretensioso,impessoalidade,socioambiental,cônjugevirago,intransigência,aplicabilidade,procrastinador,desprendimento,trazeràbaila,funcionalidade,potencialidade,principalmente,excentricidade,licenciosidade,prestatividade,estratificação,congratulações,pusilanimidade,inconveniência,procrastinação,exequibilidade,insubstituível,extraordinária,estelionatário,dissolutamente,resplandecente,coercitividade,epistemológico,credenciamento,individualismo,abundantemente,jurisprudência,biodiversidade,plausibilidade,internalização,disponibilizar,acessibilidade,multiplicidade,implicitamente,constantemente,aleatoriamente,exclusivamente,perfeccionista,impressionante,questionamento,grandiloquente,mençãohonrosa,esclarecimento,intermunicipal,minuciosamente,indiscriminado,frequentemente,permissividade,semianalfabeto,sobrecarregado,concessionária,loys,vanessa,syol,ucl,lorem,não,de,pode,processar,brasigran,corcovado,minas,teclado,novapalavra,média,";
        private static string nomeArquivo = "dicionario";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitSetup();
            Application.Run(new frmNovo());
        }



        private static void InitSetup()
        {
            if(!Directory.Exists(diretorio))
            {
                DirectoryInfo di = Directory.CreateDirectory(diretorio);
            }

            string path = $@"c:\temp\{nomeArquivo}.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(dadosDicionario);
                }
            }
        }

    }
}