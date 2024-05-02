
   
    const scene = new THREE.Scene();


    const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
    camera.position.z = 50;

 
    const renderer = new THREE.WebGLRenderer();
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.getElementById('background').appendChild(renderer.domElement);

   
    const galaxyGeometry = new THREE.BufferGeometry();
    const positions = [];
    for (let i = 0; i < 10000; i++) {
            const x = THREE.MathUtils.randFloatSpread(2000);
    const y = THREE.MathUtils.randFloatSpread(2000);
    const z = THREE.MathUtils.randFloatSpread(2000);
    positions.push(x, y, z);
        }
    galaxyGeometry.setAttribute('position', new THREE.Float32BufferAttribute(positions, 3));
    const galaxyMaterial = new THREE.PointsMaterial({color: 0xffffff });
    const galaxy = new THREE.Points(galaxyGeometry, galaxyMaterial);
    scene.add(galaxy);

   
    function animate() {
        requestAnimationFrame(animate);

    galaxy.rotation.x += 0.0005;
    galaxy.rotation.y += 0.0005;

    renderer.render(scene, camera);
        }

    animate();

       
        window.addEventListener('resize', () => {
        camera.aspect = window.innerWidth / window.innerHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(window.innerWidth, window.innerHeight);
        });
