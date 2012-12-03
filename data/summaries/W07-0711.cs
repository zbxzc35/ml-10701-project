Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
P02-1038
The BLEU metric (Papineni et al., 2002) and the closely related NIST metric (Doddington, 2002) along with WER and PER 48 have been widely used by many machine translation researchers.
P02-1040
Och, Hermann Ney.2002 Discriminative training and maximum entropy models.
P02-1038
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
P03-1021
Och. 2000.
C00-2163 P00-1056
In (Och and Ney, 2000a), the word null is introduced to generate the French words that don't align to any English words.
C00-2163 P00-1056
Alignments of both directions are generated and then are combined by heuristic rules described in (Och and Ney 2000b).
C00-2163 P00-1056
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
We evaluated the translation quality of the system using the BLEU metric (Papineni et al., 2002).
P02-1040
However, as discussed in (Toutanova et al.2002),the word dependent selftransition model can be viewed as an approximation of fertility model.
W02-1012
The classical approaches to word alignment are based on IBM models 1-5 (Brown et al., 1994) and the HMM based alignment model (Vogel et al., 1996) (Och and Ney, 2000a, 2000b), while recently discriminative approaches (Moore, 2006) and syntax based approaches (Zhang and Gildea, 2005) for word alignment are also studied.
C00-2163 C96-2141 P00-1056 P05-1059 P06-1065
? = . Then, Vogel et al.(1996) give 1 11 1 1 (|) (|,)(|) j J J JI jj ja ja pf e pa a Ipf e ??
C96-2141
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
P03-1021
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
P03-1021
Moses has shown that it achieves results comparable to the most competitive and widely used statistical machine translation systems in translation quality and run-time (Shen et al.2006). It features all the capabilities of the closed sourced Pharaoh decoder (Koehn 2004).
W04-3250
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017 P02-1040
In order to improve transition models in the HMM based alignment, Och and Ney (2000a) extended the transition models to be word-class dependent.
C00-2163 P00-1056
Och and Ney (2000a) have suggested estimating word-class based transition models so as to provide more detailed transition probabilities.
C00-2163 P00-1056
These models are combined in a log-linear framework with different weights (Och and Ney, 2002).
P02-1038
P. Koehn, 2004a, Statistical Significance Tests for Machine Translation Evaluation, in Proceedings of EMNLP.
W04-3250
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
To evaluate the result of the translation, the BLEU metric (Papineni et al.2002) was used.
P02-1040
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017 P03-1021
models (Och et al., 2004; Koehn et al., 2003; 
N03-1017 P03-1021
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017 W04-3250
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P02-1038 P02-1040 P03-1021
Evaluation The BLEU score (Papineni et al., 2002) was defined to measure overlap between a hypothesized translation and a set of human references.
P02-1040
Minimum Error Rate Training for Statistical Machine Translation, In Proceedings of the 41th Annual Meeting of the Association for Computation Linguistics, Sapporo Kishore Papineni, Salim Roukos, Todd Ward, and Wei-Jing Zhu, 2002.
P02-1040
As in (Koehn, 2004), the decoder takes a record of any recombined hypothesis, allowing for a rigorous N-best generation.
W04-3250
2.1 Log-linear Model The prevalent translation model in modern systems is a conditional log-linear model (Och and Ney, 2002).
P02-1038
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
P03-1021
Kishore Papineni et al.2002. BLEU : A Method for Automatic Evaluation of Machine Translation.
P02-1040
Finally, we further smooth transition probabilities with a uniform distribution as described in (Och and Ney, 2000a), __ 1 (|,) (1 )(|,) jj jj p aa I paa I I ??=??????.
C00-2163 P00-1056
Deng and Byrne in (2005) improved this idea.
H05-1022
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
N03-1017
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
Using this annotation, we report the word alignment performance in terms of alignment error rate (AER) as defined by Och and Ney (2000a): |||| 1 |||| A SAP AER AS ????
C00-2163 P00-1056
In (Toutanova et al., 2002), the word dependent self-transition probability P(stay|e) is interpolated with the global HMM self-transition probability to alleviate the data sparsity problem, where an interpolation weight is used for all words and that weight is tuned on a hold-out set.
W02-1012
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
In the HMM based alignment model (Vogel et al., 1996), it is assumed that the HMM transition probabilities depend only on the jump width from the last state to the next state.
C96-2141
Och. 2003.
P03-1021
In order to verify whether these gains from WDHMM are statistically significant, we implemented paired bootstrap resampling method proposed by Koehn (2004b) to compute statistical significance of the above test results.
W04-3250
BLEU (Papineni et al, 2002) was devised to provide automatic evaluation of MT output.
P02-1040
the Bleu score (Papineni et al., 2002) changes be-
P02-1040
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
Franz J. Och and Hermann Ney. 2000. Improved statis-
C00-2163 P00-1056
Tests sentencepairs were manually aligned and were marked with both sure and possible alignments (Och and Ney 2000a).
C00-2163 P00-1056
This transformation searches an adequate monotonic segmentation for each of the m source-target language pairs on the basis of bilingual alignments such as those given by GIZA++ (Och, 2000).
C00-2163 P00-1056
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
N03-1017 P03-1021
In this paper, we present improvements to the HMM based alignment model originally proposed by (Vogel et al., 1996, Och and Ney, 2000a).
C00-2163 C96-2141 P00-1056
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
As suggested in (Liang et al., 2006), we also use two separate sets of distortion parameters for transitioning into the first state, and for transitioning out of the last state, respectively.
N06-1014
The most widely used are Word Error Rate (WER), Position independent word Error Rate (PER), the BLEU score (Papineni et al., 2002) and the NIST score (Doddington, 2002).
P02-1040
The Pharaoh phrase-based decoder (Koehn 2004b) was used for decoding.
W04-3250
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
In the next section we briefly review modeling of transition probabilities in a conventional HMM alignment model (Vogel et al., 1996, Och and Ney, 2000a).
C00-2163 C96-2141 P00-1056
HMM alignment model We briefly review the HMM based word alignment models (Vogel, 1996, Och and Ney, 2000a).
C00-2163 C96-2141 P00-1056
We also trained IBM model 4 using GIZA++ provided by Och and Ney (2000c), where 5 iterations of model 4 training was performed after 5 iterations of model 1 plus 5 iterations of HMM.
C00-2163 P00-1056
Fig. 1 only presents AER results that are calculated after combination of word alignments of both E??F and F??E directions based on a set of heuristics proposed by Och and Ney (2000b).
C00-2163 P00-1056
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
P02-1040 P03-1021
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
 ThePotentialandLimitationsofAutomatic SentenceExtractionforSummarization Chin-YewLinandEduardHovy UniversityofSouthernCalifornia/InformationSciencesInstitute 4676AdmiraltyWay MarinadelRey,CA90292,USA {cyl,hovy}@isi.edu   Abstract Inthispaperwepresentanempiricalstudyof thepotentialandlimitationofsentenceextraction in text summarization. Our results show that the single document generic summarizationtaskasdefinedinDUC2001needstobe carefullyrefocusedasreflectedinthelowinter-human agreement at 100-word 1 (0.40 score) and high upper bound at full text 2  (0.88) summaries. For 100-word summaries, theperformanceupperbound,0.65,achieved oracleextracts 3.Suchoracleextractsshowthe promise of sentence extraction algorithms; however, we first need to raise inter-human agreementtobeabletoachievethisperformance level. We show that compression is a promisingdirectionandthatthecompression ratioofsummariesaffectsaveragehumanand systemperformance. 1 Introduction Most automatic text summarization systems existing todayareextractionsystemsthatextractpartsoforiginal documents and output the results as summaries. Among them, sentence extraction is by far the most  1 Wecomputeunigramco-occurrencescoreofapairofmanual summaries, one as candidate summary and the other as reference. 2 Wecomputeunigramco-occurrencescoresofafulltextand itsmanualsummariesof100words.Thesescoresarethebest achievable using the unigram co-occurrence scoring metric sinceallpossiblewordsarecontainedinthefulltext.Three manualsummariesareused. 3 Oracle extracts are the best scoring extracts generated by exhaustive search of all possible sentence combinations of 1005words. popular (Edmundson 1969, Luhn 1969, Kupiec et al. 1995,Goldsteinetal.1999,HovyandLin1999).The majorityofsystemsparticipatinginthepastDocument Understanding Conference (DUC 2002), a large scale summarization evaluation effort sponsored by the US government, are extraction based. Although systems basedoninformationextraction(RadevandMcKeown 1998,Whiteetal.2001,McKeownetal.2002)anddiscourseanalysis(Marcu1999b,Strzalkowskietal.1999) alsoexist,wefocusourstudyonthepotentialandlimitationsofsentenceextractionsystemswiththehopethat ourresultswillfurtherprogressinmostoftheautomatic textsummarizationsystemsandevaluationsetup. TheevaluationresultsofthesingledocumentsummarizationtaskinDUC2001and2002(DUC2002,Paul& Liggett2002)indicatethatmostsystemsareasgoodas thebaselinelead-basedsystemandthathumansaresignificantlybetter,thoughnotbymuch.Thisleadstothe beliefthatlead-basedsummariesareasgoodaswecan get for single document summarization in the news genre, implying that the research community should investfutureeffortsinotherareas.Infact,averyshort summary of about 10 words (headline-like) task has replaced the single document 100-word summary task inDUC2003.Thegoalofthisstudyistorenewinterest in sentence extraction-based summarization and its evaluationby estimatingtheperformanceupperbound usingoracleextracts,andtohighlighttheimportanceof taking into account the compression ratio when we evaluateextractsorsummaries. Section 2 gives an overview of DUC relevant to this study.Section3introducesa recall-basedunigram cooccurrenceautomaticevaluationmetric.Section4presentstheexperimentaldesign.Section5showstheempirical results. Section 6 concludes this paper and discussesfuturedirections.  2 DocumentUnderstandingConference Fully automatic single-document summarization was one of two main tasks in the 2001 Document UnderstandingConference.Participantswererequiredtocreate a generic 100-word summary.There were 30 test setsinDUC2001andeachtestsetcontainedabout10 documents.Foreachdocument,onesummarywascreated manually as the ideal model summary at approximately 100 words.We will refer to this manual summary as H1. Two other manual summaries were alsocreatedataboutthatlength.Wewillrefertothese twoadditionalhumansummariesasH2  andH3.Inaddition,baselinesummarieswerecreatedautomaticallyby taking the first n sentences up to 100 words. We will referthisbaselineextractasB1. 3 UnigramCo-OccurrenceMetric Inarecentstudy(LinandHovy2003),weshowedthat therecall-basedunigramco-occurrenceautomaticscoringmetriccorrelatedhighlywithhumanevaluationand has high recall and precision in predicting statistical significanceofresultscomparingwithitshumancounterpart. The idea is to measure the content similarity betweenasystemextractandamanualsummaryusing simple n-gram overlap. A similar idea called IBM BLEU score has proved successful in automatic machinetranslationevaluation(Papinenietal.2001,NIST 2002).Forsummarization,wecanexpressthedegreeof contentoverlapintermsofn-grammatchesasthefollowingequation: )1( )( )( }{ }{       = UnitsModelCCgramn UnitsModelCCgramn match n gramnCount gramnCount C  Modelunitsaresegmentsof manual summaries.They are typically either sentences or elementary discourse unitsasdefinedbyMarcu(1999b).Count match (n-gram) is the maximum number of n-grams co-occurring in a systemextractandamodelunit.Count(n-gram)isthe number of n-grams in the model unit. Notice that the averagen-gramcoveragescore,C n,asshowninequation1,isarecall-basedmetric,sincethedenominatorof equation 1 is the sum total of the number of n-grams occurringinthemodelsummaryinsteadofthesystem summaryandonlyonemodelsummaryisusedforeach evaluation. In summary, the unigram co-occurrence statisticsweuseinthefollowingsectionsarebasedon thefollowingformula: )2(logexp),(         =  = j in nn CwjiNgram  Wherej i,iandjrangefrom1to4,andw n is1/(ji+1).Ngram(1,4)isaweightedvariablelengthn-gram match score similar to the IBM BLEU score; while Ngram(k,k),i.e.i=j=k,issimplytheaveragek-gram co-occurrencescoreC k .Inthisstudy,weseti=j=1, i.e.unigramco-occurrencescore. Withatestcollectionavailableandanautomaticscoring metric defined, we describe the experimental setup in thenextsection. 4 ExperimentalDesigns As stated in the introduction, we aim to find the performanceupperboundofasentenceextractionsystem andtheeffectofcompressionratioonitsperformance. We present our experimental designs to address these questionsinthefollowingsections. 4.1 Performance Upper Bound Estimation UsingOracleExtract Inordertoestimatethepotentialofsentenceextraction systems,itisimportanttoknowtheupperboundthatan ideal sentence extraction method might achieve and howfarthestate-of-the-artsystemsareawayfromthe bound. If the upper bound is close to state-of-the-art systems performance then we need to look for other summarizationmethodstoimproveperformance.Ifthe upper bound is much higher than any current systems canachieve,thenitisreasonabletoinvestmoreeffortin sentence extraction methods. The question is how to estimatetheperformanceupperbound.Oursolutionis tocastthisestimationproblemasanoptimizationproblem. We exhaustively generate all possible sentence combinationsthatsatisfygivenlengthconstraintsfora summary, for example, all the sentence combinations totaling 1005 words. We then compute the unigram co-occurrence score for each sentence combination, against the ideal. The best combinations are the ones withthehighestunigramco-occurrencescore.Wecall this sentence combination the oracle extract. Figure 1 showsanoracleextractfordocumentAP900424-0035. OneofitshumansummariesisshowninFigure2.The oracle extract covers almost all aspects of the human summaryexceptsentences5and6andpartofsentence 4.However,ifweallowtheautomaticextracttocontain morewords,forexample,150wordsshowninFigure3, the longeroracleextractthen covers everythinginthe humansummary.Thisindicatesthatlowercompression can boost system performance. The ultimate effect of compressioncanbecomputedusingthefulltextasthe oracleextract,sincethefulltextshouldcontaineverything included in the human summary. That situation provides the best achievable unigram co-occurrence score.Anearoptimalscorealsoconfirmsthevalidityof usingtheunigramco-occurrencescoringmethodasan automaticevaluationmethod.  4.2 Compression Ratio and Its Effect on System Performance Oneimportantfactorthat affectsthe averageperformance of sentence extraction system is the number of sentences contained in the original documents. This factorisoftenoverlookedandhasneverbeenaddressed systematically. For example, if a document contains onlyonesentencethenthisdocumentwillnotbeuseful indifferentiatingsummarizationsystemperformance there is only one choice. However, for a document of 100sentencesandassumingeachsentenceis20words long, there are C(100,5) = 75,287,520 different 100wordextracts.Thishugesearchspacelowersthechance of agreement between humans on what constitutes a good summary. It also makes system and human performance approach average since it is more likely to includesomegoodsentencesbutnotallofthem.EmpiricalresultsshowninSection5confirmthisandthat leadsustothequestionofhowtoconstructacorpusto evaluatesummarizationsystems.Wediscussthisissue intheconclusionsection. 4.3 Inter-HumanAgreementandItsEffecton SystemPerformance In this section we study how inter-human agreement affects system performance. Lin and Hovy (2002) reportedthat, comparedtoa manually createdideal,humansscoredabout0.40inaveragecoveragescoreand the best system scored about 0.35. According to these numbers,wemightassumethathumanscannotagreeto eachotheronwhatisimportantandthebestsystemis almostasgoodashumans.Ifthisistruethenestimating anupperboundusingoracleextractsismeaningless.No matterhowhightheestimatedupperboundsmaybe,we probablywouldneverbeabletoachievethatperformance due to lack of agreement between humans: the oracle approximating one human would fail miserably withanother.Thereforewesetupexperimentstoinvestigatethefollowing: 1. Whatisthedistributionofinter-humanagreement? Figure3.A150-wordoracleextractfordocumentAP900424-0035. Figure 2. A manual summary for document AP900424-0035. Figure1.A100-wordoracleextractfordocumentAP900424-0035. <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC> <DOC> <TEXT> <SSNTNO="1">ElizabethTaylorbattledpneumoniaatherhospital, assistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">AnalysisofthetissuesamplewasexpectedtobecompletebyThursday.</S> <SSNTNO="4">Ms.Sam,spokeswomansaid"itisserious,buttheyare reallypleasedwithherprogress.</S> <SSNTNO="5">She'snotwell.</S> <SSNTNO="6">She'snotonherdeathbedoranything.</S> <SSNTNO="7">Anotherspokeswoman,LisaDelFavaro,saidMiss Taylor'sfamilywasatherbedside.</S> <SSNTNO="8">Duringanearlyfatalboutwithpneumoniain1961,Miss Taylorunderwentatracheotomytohelpherbreathe.</S> </TEXT> </DOC> <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="4">The58-year-oldactress,whowonbest-actressOscars for``Butterfield8''and``Who'sAfraidofVirginiaWoolf,''hasbeen hospitalizedmorethantwoweeks.</S> <SSNTNO="8">Herconditionispresentlystabilizingandherphysicians arepleasedwithherprogress.''</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="14">She'snotwell.</S> <SSNTNO="15">She'snotonherdeathbedoranything,''Ms.Samsaid lateMonday.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC>  2. Howdoesastate-of-the-artsystemdifferfrom averagehumanperformanceatdifferentinterhumanagreementlevels? We present our results in the next section using 303 newspaperarticlesfromtheDUC2001singledocument summarizationtask.Besidestheoriginaldocuments,we also have three human summaries, one lead summary (B1), and one automatic summary from one top performingsystem(T)foreachdocument. 5 Results In order to determine the empirical upper and lower bounds of inter-human agreement, we first ran crosshumanevaluationusingunigramco-occurrencescoring through six human summary pairs, i.e. (H1,H2), (H1,H3),(H2,H1),(H2,H3),(H3,H1),and(H3,H2).For a summary pair (X,Y), we used X as the model summaryandYasthesystemsummary.Figure4showsthe distributionsoffourdifferentscenarios.TheMaxHdistribution picks the best inter-human agreement scores foreachdocument,theMinHdistributiontheminimum one,theMedHdistributionthemedian,andthe AvgH distributiontheaverage.Theaverageofthebestinterhuman agreement and the average of average interhumanagreementdifferbyabout10percentinunigram co-occurrencescoreand18percentbetweenMaxHand MinH. These big differences might come from two sources. The first one is the limitation of the unigram 0 10 20 30 40 50 60 70 80 0.00 0.05 0.10 0.15 0.20 0.25 0.30 0.35 0.40 0.45 0.50 0.55 0.60 0.65 0.70 0.75 0.80 0.85 0.90 0.95 1.00 UnigramCo-occurrenceScores #  of  I n st an ce s AvgH MaxH MedH MinH AverageMAX=0.50 AverageAVG=0.40 AverageMED=0.39 AverageMIN=0.32 Figure 4. DUC 2001 single document interhuman unigram co-occurrence score distributions for maximum, minimum, average, and median. 0.00 0.10 0.20 0.30 0.40 0.50 0.60 0.70 0.80 0.90 1.00 D 4 1.
P02-1040
Toutanova et al.(2002) has proposed to 86 estimate a word-dependent self-transition model P(stay|e) so that each word can have its own probability to decide whether to stay or jump to a different word.
W02-1012
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
Likelihood Used in earlier models (Och and Ney, 2002), the likelihood criterion is defined as the likelihood of an oracle hypothesis e(t)k??, typically a single reference translation, or alternatively the closest match which was decoded.
P02-1038
In practice, we can bucket the distortion parameters {c(d)} into a few buckets as implemented in (Liang et al., 2006).
N06-1014
ZA++ (Och and Ney, 2000) on the training corpus 
C00-2163 P00-1056
? (1) In the HMM of (Vogel et al., 1996), it is further assumed these transition probabilities 1 (|,) ??
C96-2141
84 5.2 Machine translation on Europarl corpus We further tested our WDHMM on a phrase-based machine translation system to see whether our improvement on word alignment can also improve MT accuracy measured by BLEU score (Papineni et al., 2002).
P02-1040
Later Deng and Byrne (2005) proposed a word dependent phrase length model to better model state occupancy.
H05-1022