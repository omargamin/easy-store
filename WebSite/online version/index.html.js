window.onload = function () {
    fetch('apps.json')
        .then(response => response.json())
        .then(data => {
            const appContainer = document.getElementById('app-container');

            // عرض كل لعبة
            for (let app in data) {
                const appData = data[app];

                // إنشاء العناصر لعرض اللعبة
                const appDiv = document.createElement('div');
                appDiv.classList.add('app-card', 'p-4', 'm-4', 'border', 'rounded-lg', 'shadow-lg', 'max-w-xs', 'bg-gray-800', 'text-white');

                // إضافة الصورة
                const appImage = document.createElement('img');
                appImage.src = appData.image; // استخدام الصورة من JSON
                appImage.alt = appData.name;
                appImage.classList.add('w-full', 'h-48', 'object-cover', 'rounded-t-lg');
                appDiv.appendChild(appImage);

                // إضافة اسم اللعبة
                const appName = document.createElement('h2');
                appName.textContent = appData.name;
                appName.classList.add('text-xl', 'font-semibold', 'mt-4');
                appDiv.appendChild(appName);

                // إضافة رابط اللعبة
                const appLink = document.createElement('a');
                appLink.href = appData.link;
                appLink.textContent = 'رابط اللعبة';
                appLink.classList.add('text-blue-400', 'mt-2', 'block');
                appDiv.appendChild(appLink);

                // إضافة اللعبة إلى الـ container
                appContainer.appendChild(appDiv);
            }
        })
        .catch(error => {
            console.error('Error loading apps.json:', error);
        });
};