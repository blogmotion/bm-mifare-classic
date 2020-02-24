#!/bin/bash
# Author: Mr Xhark -> @xhark
# License : Creative Commons http://creativecommons.org/licenses/by-nd/4.0/deed.fr
# Website : http://blogmotion.fr/internet/securite/mct2dmp-convertir-dump-hexa-binaire-18125

if [[ ! $1 ]]; then
  echo -e "\n\tOops! Aucun dump hexa en parametre (MCT dump)"
  echo -e "\tUsage: $(basename $0) <mct.hex>\n"
  exit 1
fi

mctdump=$1

# supprime l'extension du fichier d'entrée (.txt ou autre)
outfile=$(echo ${mctdump%%.*}".DMP")

# garde uniquement le contenu en hexa
vhexa=$(grep '^[[:xdigit:]]' $mctdump)

# conversion hexa en binaire
echo $vhexa | xxd -r -p > $outfile
echo -e "\n\t > Conversion OK: ${outfile} \n\n\tAppuyez sur ENTER pour voir le dump, puis Ctrl+C pour sortir...\n\n"
read -p ""

# affichage
hexeditor $outfile # graphique: ghex $outfile

exit 0