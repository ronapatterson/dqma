async function getUserRole() {
    try {
        const response = await fetch('/api/user/role', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let roles = await response.json();
            var role = roles.find('Admin');

            if (role !== '' || role !== null) {
                document.getElementById('approval').style.display = 'inline';
            }
        }
    } catch (e) {
        console.log(e);
    }
}