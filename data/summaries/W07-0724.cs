Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
J93-2003
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
P03-1021
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
N03-1017 P03-1021
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
N03-1017
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
N03-1017
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
N03-1017
This feature, which is based on the lexical parameters of the IBM Model 1 (Brown et al., 1993), provides a complementary probability for each tuple in the translation table.
J93-2003
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
N03-1017
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
P03-1021
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
N03-1017
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
N03-1017
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
P03-1021
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017 P03-1021
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
N03-1017
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
The interested reader is referred to (Simard et al., 2007).
W07-0728
BLEU score using the algorithm described in (Och, 2003).
P03-1021
A monotonic segmentation copes with monotonic alignments, that is, j < k ??aj < ak following the notation of (Brown et al., 1993).
J93-2003
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
N03-1017 W06-1607
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
N03-1017
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
N03-1017
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
P03-1021
Edinburgh, UK (Dugast et al., 2007) systran-nrc National Research Council, Canada (Simard et al., 2007) ucb University of California at Berkeley, USA (Nakov and Hearst, 2007) uedin University of Edinburgh, UK (Koehn and Schroeder, 2007) umd University of Maryland, USA (Dyer, 2007) upc University of Catalonia, Spain (Costa-Juss`a and Fonollosa, 2007) upv University of Valencia, Spain (Civera and Juan, 2007) Table 1: Participants in the shared task.
W07-0728
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
P03-1021
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
Compounds tend to lead to sparse data problems and splitting them has been shown to improve German-English translation (Koehn and Knight, 2003).
N03-1017
One can perhaps identify these using posterior probabilities (e.g., using techniques in Zens and Ney (2006)) and generate additional morphologically valid words that are ?close??and construct a lattice that can be rescored.
W06-3110
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
N03-1017
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
P03-1021
We pruned the generated phrase tables following the method introduced in (Johnson et al., 2007).
D07-1103
models (Och et al., 2004; Koehn et al., 2003; 
N03-1017 P03-1021
This is akin to post-editing (though definitely not akin to the much more sophisticated approach in described in Simard et al.(2007)). We proceeded as follows: We used the selective segmentation based model above and decoded our English training data ETrain and English test data ETest to obtain T1Train and T1Test reStep BLEU From Table 4 24.61 Iter.
W07-0728
Brown et al.(1993) defined a series of probabilistic translation models for MT purposes.
J93-2003
First, we used several types of phrase table smoothing in the WMT 2007 system because this proved helpful on other translation tasks: relative frequency estimates, Kneser-Neyand Zens-Ney-smoothed probabilities (Foster et al., 2006).
W06-1607 W06-3110
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
N03-1017 P03-1021
Based on one of the statistical models proposed by Brown et al.(1993), the basic principle of our translation model is the following: given a corpus of aligned sentences, if two words often co-occur in the source and target sentences, there is a good likelihood that they are translations of each other.
J93-2003
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
J93-2003 N03-1017
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J93-2003
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
P03-1021
Zens, Richard and Hermann Ney, 2006.
W06-3110
For details on the posterior probabilities, see (Ueffing and Ney, 2007; Zens and Ney, 2006).
W06-3110
See (Johnson et al., 2007) for details.
D07-1103
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
We provide a basic description of this system here; for more details see (Johnson et al., 2006).
W06-3118
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
J93-2003
DeNero et al.(2006) tried a different generative phrase translation model analogous to IBM word-translation Model 3 (Brown et al., 1993), and again found that the standard model outperformed their generative model.
J93-2003
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
N03-1017
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
P03-1021
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
P03-1021
We wanted to test the following hypotheses: ??Translation models based on lemmas will improve translation quality (Popovi and Ney, 2004) ??Decompounding German nominal compounds will improve translation quality (Koehn and Knight, 2003) ??Re-ordering models based on word forms and parts-of-speech will improve translation quality (Zens and Ney, 2006).
N03-1017 W06-3110
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
N03-1017
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
P03-1021
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
P03-1021
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
P03-1021
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
N03-1017
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
N03-1017
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
Och. 2003.
P03-1021 P03-1021 P03-1021
The lexical scores are computed as the (unnormalized) log probability of the Viterbi alignment for a phrase pair under IBM word-translation Model 1 (Brown et al., 1993).
J93-2003
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
D. McClosky, E. Charniak, and M. Johnson. 2006. Effective Self-Training for Parsing. In Proceedings of HLT-NAACL, pages 152159.
W06-3118
Note that we did not use the decision-treebased distortion models described in (Johnson et al., 2006) here because they did not improve translation quality.
W06-3118
Koehn and Knight, 2003).
N03-1017
These lists are rescored with the different models described above, a character penalty, and three different features based on IBM Models 1 and 2 (Brown et al., 1993) calculated in both translation directions.
J93-2003
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
J93-2003 N03-1017
References Koehn, Philipp and Kevin Knight, 2003.
N03-1017
We speculated that this may have been due to non-smooth component models, and tried various smoothing schemes, including Kneser-Ney phrase table smoothing similar to that described in (Foster et al., 2006), and binary features to indicate phrasepair presence within different components.
W06-1607
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
P03-1021