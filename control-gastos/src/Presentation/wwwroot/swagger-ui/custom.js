document.addEventListener("DOMContentLoaded", function () {
    const observer = new MutationObserver(function (mutations, obs) {
        const swaggerRoot = document.querySelector('#swagger-ui .wrapper');
        if (swaggerRoot && swaggerRoot.children.length > 0) {
            obs.disconnect();
            setTimeout(buildCustomLayout, 400);
        }
    });
    observer.observe(document.body, { childList: true, subtree: true });
});

function buildCustomLayout() {
    const originalSwagger = document.querySelector('#swagger-ui');
    if (document.getElementById('custom-layout')) return;

    const layout = document.createElement('div');
    layout.id = 'custom-layout';

    layout.innerHTML = `
        <div id="custom-topbar">
            <div class="topbar-logo">Control Gastos</div>
            <div class="topbar-links">
                <a href="#" class="active">Documentación</a>
                <a href="#">API</a>
                <a href="#">Versiones</a>
            </div>
            <button class="repo-btn" onclick="window.open('https://github.com/JorgeLim/Implementacion-mediante-Vibe-Coding-e-IA-', '_blank')">Repositorio</button>
        </div>
        <div id="custom-main">
            <div id="custom-sidebar">
                <div class="sidebar-header">
                    <h2>Control Gastos</h2>
                    <span>Doc. Técnica v2.4</span>
                </div>
                <ul class="sidebar-menu" id="sidebar-menu-list">
                    <li class="sidebar-all active" data-tag="all"><a href="#">📋 Todos</a></li>
                </ul>
            </div>
            <div id="swagger-ui-container">
                <div class="custom-search">
                    🔍 <input type="text" id="endpoint-search" placeholder="Buscar por endpoint o descripción..." />
                </div>
            </div>
        </div>
    `;

    document.body.insertBefore(layout, originalSwagger);
    const container = document.getElementById('swagger-ui-container');
    container.appendChild(originalSwagger);

    // Build sidebar from swagger tags
    setTimeout(buildSidebar, 600);
}

const MODULE_ICONS = {
    'Usuario':       '👤',
    'Areas':         '🏢',
    'Roles':         '🛡️',
    'CentrosCosto':  '📊',
    'Presupuestos':  '💰',
    'Api':           '⚙️',
};

function getIcon(tag) {
    for (const key in MODULE_ICONS) {
        if (tag.toLowerCase().includes(key.toLowerCase())) return MODULE_ICONS[key];
    }
    return '📄';
}

function buildSidebar() {
    const tagSections = document.querySelectorAll('.swagger-ui .opblock-tag-section');
    const menu = document.getElementById('sidebar-menu-list');
    if (!menu) return;

    // Remove old dynamic items
    menu.querySelectorAll('.sidebar-dynamic').forEach(e => e.remove());

    tagSections.forEach(section => {
        const tagEl = section.querySelector('[data-tag]');
        if (!tagEl) return;
        const tag = tagEl.getAttribute('data-tag');
        if (!tag) return;

        const icon = getIcon(tag);
        const li = document.createElement('li');
        li.className = 'sidebar-dynamic';
        li.setAttribute('data-tag', tag);
        li.innerHTML = `<a href="#">${icon} ${tag}</a>`;

        li.addEventListener('click', (e) => {
            e.preventDefault();
            filterByTag(tag, li);
        });

        menu.appendChild(li);
    });

    // "All" button
    const allItem = menu.querySelector('.sidebar-all');
    if (allItem) {
        allItem.addEventListener('click', (e) => {
            e.preventDefault();
            filterByTag('all', allItem);
        });
    }

    // Search functionality
    const searchInput = document.getElementById('endpoint-search');
    if (searchInput) {
        searchInput.addEventListener('input', () => {
            const q = searchInput.value.toLowerCase();
            document.querySelectorAll('.swagger-ui .opblock').forEach(op => {
                const path = op.querySelector('.opblock-summary-path')?.textContent?.toLowerCase() || '';
                const method = op.querySelector('.opblock-summary-method')?.textContent?.toLowerCase() || '';
                op.style.display = (!q || path.includes(q) || method.includes(q)) ? '' : 'none';
            });
        });
    }
}

function filterByTag(tag, clickedEl) {
    // Update active state
    document.querySelectorAll('#sidebar-menu-list li').forEach(li => li.classList.remove('active'));
    clickedEl.classList.add('active');

    const tagSections = document.querySelectorAll('.swagger-ui .opblock-tag-section');
    tagSections.forEach(section => {
        const tagEl = section.querySelector('[data-tag]');
        const sectionTag = tagEl?.getAttribute('data-tag');
        if (tag === 'all') {
            section.style.display = '';
        } else {
            section.style.display = (sectionTag === tag) ? '' : 'none';
        }
    });
}
