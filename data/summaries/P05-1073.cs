(Punyakanok et al., 2004) use a linear programming framework to ensure that the only argument frames which get probability mass are ones that respect global constraints on argument labels.
W04-2421
The release of semantically annotated corpora such as FrameNet (Baker et al., 1998) and PropBank (Palmer et al., 2003) has made it possible to develop high-accuracy statistical models for automated semantic role labeling (Gildea and Jurafsky, 2002; Pradhan et al., 2004; Xue and Palmer, 2004).
J02-3001 N04-1030 P98-1013 W04-3212
Whole Label Sequence: As observed in previous work (Gildea and Jurafsky, 2002; Pradhan et al., 2004), including information about the set or sequence of labels assigned to argument nodes should be very helpful for disambiguation.
J02-3001 N04-1030
We should note that Xue and Palmer (2004) define a similar feature template, called syntactic frame, which often captures similar information.
W04-3212
We do stress however that the joint framework and features proposed here can also be used when only a shallow parse (chunked) representation is available as in the CoNLL-2004 shared task (Carreras and M`arquez, 2004).
W04-2412
We present performance results on the February 2004 version of PropBank on gold-standard parse trees as well as results on automatic parses generated by Charniak’s parser (Charniak, 2000).
A00-2018
We trained and tested on automatic parse trees from Charniak’s parser (Charniak, 2000).
A00-2018
VOICE: Active or passive relative to predicate HEAD WORD OF PHRASE SUB-CAT: CFG expansion of predicate’s parent Additional Features (Pradhan et al., 2004) FIRST/LAST WORD LEFT/RIGHT SISTER PHRASE-TYPE LEFT/RIGHT SISTER HEAD WORD/POS PARENT PHRASE-TYPE PARENT POS/HEAD-WORD ORDINAL TREE DISTANCE: Phrase Type with appended length of PATH feature NODE-LCA PARTIAL PATH Path from constituent to Lowest Common Ancestor with predicate node PP PARENT HEAD WORD If parent is a PP return parent’s head word PP NP HEAD WORD/POS For a PP, retrieve the head Word / POS of its rightmost NP Selected Pairs (Xue and Palmer, 2004) PREDICATE LEMMA & PATH PREDICATE LEMMA & HEAD WORD PREDICATE LEMMA & PHRASE TYPE VOICE & POSITION PREDICATE LEMMA & PP PARENT HEAD WORD Table 1: Baseline Features and classification models can be chained in a principled way, as in Equation 1.
N04-1030 W04-3212
As previously observed (Pradhan et al., 2004), including modifying arguments in sequence features is not helpful.
N04-1030
Examples are linearly interpolated relative frequency models (Gildea and Jurafsky, 2002), SVMs (Pradhan et al., 2004), decision trees (Surdeanu et al., 2003), and log-linear models (Xue and Palmer, 2004).
J02-3001 N04-1030 P03-1002 W04-3212
(Pradhan et al., 2004) train a language model over label sequences.
N04-1030
One advantage of log-linear models over SVMs for us is that they produce probability distributions and thus identification 590 Standard Features (Gildea and Jurafsky, 2002) PHRASE TYPE: Syntactic Category of node PREDICATE LEMMA: Stemmed Verb PATH: Path from node to predicate POSITION: Before or after predicate?
J02-3001
In the February 2004 version of the PropBank corpus, annotations are done on top of the Penn TreeBank II parse trees (Marcus et al., 1993).
J93-2004
The standard features at the top of the table were defined by (Gildea and Jurafsky, 2002), and the rest are other useful lexical and structural features identified in more recent work (Pradhan et al., 2004; Surdeanu et al., 2003; Xue and Palmer, 2004).
J02-3001 N04-1030 P03-1002 W04-3212
(Gildea and Jurafsky, 2002) used the empirical probability of the set of proposed arguments as a prior distribution.
J02-3001
Several systems have incorporated such dependencies, for example, (Gildea and Jurafsky, 2002; Pradhan et al., 2004; Thompson et al., 2003) and several systems submitted in the CoNLL-2004 shared task (Carreras and M`arquez, 2004).
J02-3001 N04-1030 W04-2412