function showSolicitacoes() {
    hideAllScreens();
    document.getElementById('solicitacao').classList.add('show');
}

function showCadastroUsuario() {
    hideAllScreens();
    document.getElementById('cadastro-usuario').classList.add('show');
}

function showCadastroMoradia() {
    hideAllScreens();
    document.getElementById('cadastro-moradia').classList.add('show');
}

function showAreasComuns() {
    hideAllScreens();
    document.getElementById('cadastro-areacomum').classList.add('show');
}

function showUsodeArea() {
    hideAllScreens();
    document.getElementById('uso-area').classList.add('show');
}

function showNotificacao() {
    hideAllScreens();
    document.getElementById('notificacao').classList.add('show');
}

function showReuniao() {
    hideAllScreens();
    document.getElementById('reuniao').classList.add('show');
}

function showAta() {
    hideAllScreens();
    document.getElementById('ata').classList.add('show');
}

function showRecebimentoEncomenda() {
    hideAllScreens();
    document.getElementById('recebimento-encomenda').classList.add('show');
}


function hideAllScreens() {
    const screens = document.getElementsByClassName('screen');
    for (let i = 0; i < screens.length; i++) {
        screens[i].classList.remove('show');
        screens[i].classList.add('hidden');
    }
}

function Negar(btn) {
    let div = btn.parentNode;
    div.classList.add("red");
    div.classList.remove("green");
}

function Aprovar(btn) {
    let div = btn.parentNode;
    div.classList.add("green");
    div.classList.remove("red");
}

if (document.querySelector("#ata")) {
    const modal = document.getElementById('modal');
    const modalImage = document.getElementById('modal-image');
    const galleryImages = document.querySelectorAll('.gallery img');

    galleryImages.forEach(image => {
        image.addEventListener('click', function () {
            modal.style.display = 'flex';
            modalImage.src = this.src;
            modalImage.alt = this.alt;
        });
    });

    modal.addEventListener('click', function () {
        modal.style.display = 'none';
    });
}