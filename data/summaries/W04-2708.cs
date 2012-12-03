DT An NP-SBJ-1 NN earthquake VBD struck JJ Northern NP NNP California VP,, NP-SBJ -NONE*-1 S S-ADV VBG killing JJR more VP QP IN than CD 50 NP NNS people. . Figure 1: Penn Treebank annotation of the sentence “An earthquake struck Northern California, killing more than 50 people.” For the purpose of quantitative evaluation methods, such as NIST or BLEU, for measuring performance of translation systems, we selected a test set of 515 sentences and had them retranslated from Czech into English by 4 different translator offices, two of them from the Czech Republic and two of them from the U.S.A. 3 Transformation of Penn Treebank Phrase Trees into Dependency Structure The transformation algorithm from phrase-structure topology into dependency one, similar to transformations described by Xia and Palmer (2001), works as follows: Terminal nodes of the phrase are converted to nodes of the dependency tree.
H01-1014
Furthermore, by training GIZA++ (Och and Ney, 2003) translation model on the training part of the PCEDT extended by the manual dictionaries, we obtained a probabilistic Czech-English dictionary, more sensitive to the domain of financial news specific for the Wall Street Journal.
J03-1002
The system uses models GIZA++ and ISI ReWrite decoder (Germann et al., 2001).
P01-1030
Since Czech is a language with relatively high degree of word-order freedom, and its sentences contain certain syntactic phenomena, such as discontinuous constituents (non-projective constructions), which cannot be straightforwardly handled using the annotation scheme of Penn Treebank (Marcus et al., 1993; Linguistic Data Consortium, 1999), based on phrase-structure trees, we decided to adopt for the PCEDT the dependency-based annotation scheme of the Prague Dependency Treebank – PDT (Linguistic Data Consortium, 2001).
J93-2004
Czech analytical parsing consists of a statistical dependency parser for Czech – either Collins parser (Collins et al., 1999) or Charniak parser (Charniak, 1999), both adapted to dependency grammar – and a module for automatic analytical function assignment ( ˇZabokrtsk´y et al., 2002).
P99-1065
There have already been experimental machine translation systems MAGENTA (Hajiˇc et al., 2002) and DBMT ( ˇCmejrek et al., 2003) confirming the exploitability of the corpus and showing that we are capable of performing automatic transformations from phrase structures to dependency representation with an acceptable, though still not impeccable quality.
E03-1004