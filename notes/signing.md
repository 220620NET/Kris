download [gpg]<https://www.gnupg.org/download/>
`gpg --full-generate-key`
`gpg --list-secret-keys --keyid-format=long`
`gpg --armor --export <The key after rsa4096 >`
save that as a key on github
`git config commit.gpgsign true`
Sign away