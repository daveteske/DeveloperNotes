git checkout master
git add .
git commit -m "Checking output in for subtree"

git subtree split --prefix docs/output -b gh-pages
git push -f origin gh-pages:gh-pages
git branch -D gh-pages

# StartProcess("git", "checkout master");
# StartProcess("git", "add .");
# StartProcess("git", "commit -m \"Checking output in for subtree\"");
# StartProcess("git", "subtree split --prefix docs/output -b gh-pages");
# StartProcess("git", "push -f origin gh-pages:gh-pages");
# StartProcess("git", "branch -D gh-pages");