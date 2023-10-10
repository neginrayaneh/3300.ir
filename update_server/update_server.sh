#git clone https://negin.gitsa.ir/int/3300.ir.git master
cd /home/amir/projects/3300.ir

git checkout master
git pull
echo "================================="
echo "Backup from source before update?"
select yn in "Yes" "No"; do
    case $yn in
        Yes ) rsync -avzhce "ssh -p10944" ir3300@3300.ir:/home/ir3300/public_html/ ./backup/; break;;
        No ) break;;
    esac
done
echo "Sending updates to server"
rsync -avzhce "ssh -p10944" --exclude-from=update_server/rsync.exclude ./ ir3300@3300.ir:/home/ir3300/public_html/
cd /home/amir/projects/3300.ir
