self.addEventListener("install", e => {
    console.log("service worker installed");
});

self.addEventListener("fetch", e => {
    e.responseWith(fetch(e.request));
});

_Layout.cshtml
   <link rel="manifest" href="/Manifest.json" />

<script>
    if('serviceWorker'in navigator{
        navigator.serviceWorker.register('/service-worker.js');
    }
    </script>
