﻿using Xunit;

namespace Kbonacci.Tests2
{
    public class KbonacciTests
    {
        [Fact]
        public void Kbonacci_Test_3_and_4()
        {
            string expected = "5";
            string result = Kbonacci.KbonacciCalc(3, 4);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_2_and_4()
        {
            string expected = "5";
            string result = Kbonacci.KbonacciCalc(2, 4);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_2_and_0()
        {
            string expected = "1";
            string result = Kbonacci.KbonacciCalc(2, 0);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_5_and_0()
        {
            string expected = "1";
            string result = Kbonacci.KbonacciCalc(5, 0);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_5_and_5()
        {
            string expected = "5";
            string result = Kbonacci.KbonacciCalc(5, 5);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_5_and_10()
        {
            string expected = "129";
            string result = Kbonacci.KbonacciCalc(5, 10);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_9_and_20()
        {
            string expected = "16353";
            string result = Kbonacci.KbonacciCalc(9, 20);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_5_and_30()
        {
            string expected = "95653929";
            string result = Kbonacci.KbonacciCalc(5, 30);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_30_and_50()
        {
            string expected = "30408705";
            string result = Kbonacci.KbonacciCalc(30, 50);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Kbonacci_Test_103_and_25000()
        {
            string expected = "565460428434334686669526437876667752234622504389486560738261810865755358650001487215780351320606885080982420665308179551439369932664545859860007028670571516952156107770576667768525766399798595078134433440265681654406512237209358631651985399355263475895108992159152213032781601351591629397269241359769997426973996070641022444159257784503125822560648830899353878583397177596921059072278634544936878392141797286908798399825653804355126973572866004574116909504825076460374195133824346750301761198313164723095071390809372822455168612790044027683170720227310316077763563454536729549759595788911276756851897415275546453250355863982266688821134882783713709782142835348579980017845717297150052158098422794084996079463434019303815152212762321106331932459061500944582909498167421748295715428823134524386768594398687054316337877851298999394631082865924749937996294761866522528300944465120335424374578458964225958501280998587845336793304455466739368805232790252174662642480140448316505950509199244218918010649396089797923765799856218955035505129492336414370709953202682700493126464767945626855739563543213894819602596807121027794161216867636466915905362636479818033036461574864050415169910483072935047779794802936325533794230409487834756247051128579627664693628962104292999755484503345268862926854937752186997197359022563446438991832450183921116345915386102346991926826605399229071768869448399355932774312339739576672378851024142987083336657275697567708078594760490657699368027439927844800268504185513276308974838001460487130818616191415944633062973405420109180044149053965053240254027430759432605973623400350039661877552042010883439860116697475070747714197241523430812119165882088433141222340989541718670468560408997835096264256340100326800930930734309549413189314073328041623161184866340728272995620039193036161879278770956448432089444661077407302951549679426581431429064745538023933832783331753179727387441569391219143500937099277269895993293466700130609590852799241981891202451916040633731300280685026778258518709510632223695402862482614885881344531675964018191525141963122998906309579617901029324125716479523913733280616813326164679271248423015020129973905450669970017066233797472147465167099507532739113801622677787100209478939278559309338767310764709171088969247497093656055199947331284566025693758750163677845733211486085422243012700016287188581689941599287189499747390119054038506189995248784502369625277742903547947858560841008321980243643134583042801954765559599752595003061261688006053387572248694044795110596423011154501436776541273798423578863572512347356086660287612505713289618948139169973739892564036234827161676255607893996028906309391694307523082215526357234728551079834645588828831946522547099205405139439490620565120336055041104955189491152505642597085139773136430893796225602835349910059317934068623214744827895517229596536533765088009703529198922484572596416625242036694880965298107567076204825338002685770000070560563228385138019227293259751760623645657481188220800303813145505394893151780954116477872786283215177648878232245377986863218719949587211322080843999035035769118172724060949220156606331102430663687165179606831447938945302095394466632045809618028709113960011966674122687125255085533396938172599457149764131385117320691378164749548463893558927452620826654224762772897126521421007267943647001240324722218389473587420486947117717687916722115637004612398815874625870404341530950978531578330652355105532133875785755840000028616422800906689859212441460641747928037985060343383469909501134092100426018247285575338633829620992750353275917999939248050631164821817617964617813474699222225760395288246282433850965755803074961208743303633378406086018337457485308045378850549643570691616196821211350486201112215552323861621985805609812234985926803440729847036728617084911481795072576779495531203039941043701083373488149414879316876941314041744993566656797767217832795781531595207007163224043640111247123045636441265433283740687654338782641339790494119694851248803028444816325870143915190625742842111165533692207890439573820432921415691628415243047552489153003650338423308002681137356613036390383297277954530874304297708088627452394241614120092315594595325794223388053706524227755664947878503838169558674654925836631698397686389091972091510583100575141870307315082163078251170005358046002353834134734643266370960631065146505989156984030321660816398031668176403215368891771514217849629804803772021169757129198227130725594303487498956471847356905898097136301751964934905716655791942773541104974636525486575524422730011278979970516265758354435202874897558370891768638147222618375011464021160245548351662981690695809753480995959399624681947057239999988642184556533342615165338504664153304183028346713115330348787775608574708765460839585319003454302157594878196208375534441695262968075889575314957572563031293963518518034500712410796653449745571056890639488196003858062636902729912719971965712795171815712346118825732386159357949571462770362515220289557929186402017931507476946481465864858110311242022942140075905669966643675491374508134120222520277464394693961926272445682661070080725049882854867123534776018491623059384066569688474402485303952364262187579572622052194301236572123925370548317265723602087450487742421708102939159954571098113782237561856025492783170762141229919895769644594996729918642894885596202058749411670767854951897212284768094619042975204427803364594538024523296703244247084151291881418648983357291151991446662335488671531849007773669897351379842761907490758463792848462508476189365036666426139559212125978610332787375635228648047353077276710377653678289674817555128425653738962795668924392024785261519943040365736669644794196659588317249901961863110357847287695504225317132158861975814465913186887121003463591722959304830037377851844474882818041057664173319003752226953103362166725653647964334519853986766201923280119655363574705485215691136606187779378121935264167808091328915705059454974266729957028454764198555833664421142405196223664879943090554890529972746601837892402045488313575604093670232234723024318080904187562764661999193848999633639372579080619932959065523214080835689071617226962696496291096794990013180110470226021383542701763542739270739814011409162955656930466599112765266376409457917964043930020021112979955479135719498572470849163286085903858962893903067273116324482912005318445671372093646384850027212273965252245498857255787471037337972144682119648408451750020816022463814297023703209707521428935267979365787399503528937599441912840837087622292806579714125977037108568987514932169808700295324884269692207714987096079217992923247318375414597093816801346387641330604318920656545256907061758128781414330364876807417356393132222095563442407501204757759205208196887403384915781084307997433486400762272586775520427959545900957342636913972894898174819847684163721751241957974323705010791325324701680501313834977597696632113563328564756413767334072340874887032084018094411148202114099994526773357196833838393852779142295940777470026500904241745521886962609034319710694430176173612832766060100094594483716796570931493518677244327497006682941305354974397735832748345486345911125377337029827808325321408431343940020350242869422551830455170743370397137767571450200795231493627201962466858120945392318483229669916050822108481524457291766673589766924095900893031755123094741176159325751714970658703940657929606023555640324453668800513351640419953820547798810238783645431325779095354191725929651682655973316442189020222626742204020633303222141701435262751364612097";
            string result = Kbonacci.KbonacciCalc(103, 25000);
            Assert.Equal(expected, result);
        }  //São os valores de teto descrito no enunciado; foi útil para ver o "Calculating..." funcionando
    }
}